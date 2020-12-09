using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.Model
{
    class Elevator 
    {
        public Elevator()
        {
            CurrentFloor = 1;
            TotalWeight = 0;
            CurrentWeight = 0;
            Status = "Standby mode";
            NumTransported = 0;
            FloorsInTheDirection = 0;
        }
        private const float MaxWeight = 400f;
        private float TotalWeight;
        private float CurrentWeight;
        private int NumIdleTransport;
        private int NumTransported;
        private string Status;
        private int CurrentFloor;
        private int FloorsInTheDirection;
        public List<int> ElevatorList = new List<int>();
        private List<Person> PersonsList = new List<Person>();
        private Time StandTime = new Time();

        public event Action<string> UpdateStatus;
        public event Action MoveFloor;
        public event Action CarryFloor;
        public event Action<int> EventOpenDoors;
        public event Action UpdateTransported;

        public string getStatus()
        {
            return Status;
        }
        public int getCurrentFloor()
        {
            return CurrentFloor;
        }
        public int getTransported()
        {
            return NumTransported;
        }

        public Result SendResult(Result result)
        {
            result.setNumIdleTransport(NumIdleTransport);
            result.setNumTransported(NumTransported);
            result.setTotalWeight(TotalWeight);
            return result;
        }
        public void updateElevatorList(int floor, string status)
        {
            bool flag = false;
            if (!ElevatorList.Any())
            {
                ElevatorList.Add(floor);
                if(status == "Called the elevator")
                    GoEmtyToCall();
            }
            else
            {
                //if (CurrentFloor == floor)
                //    Stand();
                //else
                //{
    //если модули разности текущего этажа с этажом следования и с добавленным этажом одинаковые,то этаж по направлению движения
    //если по направлению, то добавляем сначала, чтобы не пропустить этаж по направлению
                    switch (Math.Sign(CurrentFloor - ElevatorList[0]) == Math.Sign(CurrentFloor - floor))
                    {
                        case true:
                            for (int i = 0; i < FloorsInTheDirection; i++)
                            {
                                if (Math.Abs(CurrentFloor - ElevatorList[i]) > Math.Abs(CurrentFloor - floor))
                                {
                                    ElevatorList.Insert(i, floor);
                                    FloorsInTheDirection++;
                                    flag = true;
                                    break;
                                }
                                else if (Math.Abs(CurrentFloor - ElevatorList[i]) == Math.Abs(CurrentFloor - floor))
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (!flag)
                            {
                                ElevatorList.Insert(FloorsInTheDirection, floor);
                                FloorsInTheDirection++;
                            }
                            break;
                        case false:
                            if (ElevatorList.Count == FloorsInTheDirection)
                            {
                                ElevatorList.Insert(FloorsInTheDirection, floor);
                            }
                            else
                            {
                                for (int i = FloorsInTheDirection; i < ElevatorList.Count; i++)
                                {
                                    if (Math.Abs(CurrentFloor - ElevatorList[i]) > Math.Abs(CurrentFloor - floor))
                                    {
                                        ElevatorList.Insert(i, floor);
                                        flag = true;
                                        break;
                                    }
                                    else if (Math.Abs(CurrentFloor - ElevatorList[0]) == Math.Abs(CurrentFloor - floor))
                                    {
                                        flag = true;
                                        break;
                                    }
                                }
                                if (!flag)
                                    ElevatorList.Insert(ElevatorList.Count, floor);
                            }
                            break;
                    //}
                }
            }
        }
        private void GoEmtyToCall()
        {
            Status = "Go emty to call";
            UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setElevatorStatus)
            NumIdleTransport++;
            if (ElevatorList[0] > CurrentFloor)
                DataBase.direction = -1;
            else
                DataBase.direction = 1;
            while (CurrentFloor != ElevatorList[0])
            {
                CurrentFloor -= DataBase.direction;
                MoveFloor?.Invoke();        //подписана SimulationForm (moveFloor)
            }
            Stand();
        }
        private void Stand()
        {
            Status = "Stand";
            UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setElevatorStatus)
            //пауза
            ElevatorList.RemoveAt(0);
            OpenDoors();
        }
        private void OpenDoors()
        {
            Status = "Open doors";
            UpdateStatus?.Invoke(Status);           //подписана SimulationForm (setElevatorStatus)
            //пауза
            EventOpenDoors?.Invoke(CurrentFloor);   //gдписаны все люди (EnterTheElevator и GetOffTheElevator)
            CheckMode();
        }
        public bool AddTime(Person person, int floor)
        {
            StandTime = StandTime + (new Time(0, 5, 0, 0));
            PersonsList.Add(person);
            CurrentWeight += person.GetWeight();
            CarryFloor += person.Addfloor;
            return ElevatorList.Exists(x => x == floor);
        }
        private void CheckMode()
        {
            StandTime = new Time(DataBase.time);
            Time currentTime = new Time(0, 5, 0, 0);
            Status = "Check mode";
            UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setElevatorStatus)

            while (DataBase.time - StandTime > currentTime)
            {
                if (CurrentWeight >= MaxWeight)
                   Signal();
            }
            CloseDoors();
        }
        private void Signal()
        {
            Status = "Signal Overload";
            UpdateStatus?.Invoke(Status);       //подписана SimulationForm (setElevatorStatus)
            while (CurrentWeight>MaxWeight)
            {
                CurrentWeight -= PersonsList[PersonsList.Count - 1].GetWeight();
                PersonsList[PersonsList.Count - 1].setStatus("Called the elevator");
                PersonsList.RemoveAt(PersonsList.Count - 1);
            }
            CheckMode();
            //последний зашедший должен выйти
        }
        public void CloseDoors()
        {
            Status = "Close doors";
            UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setElevatorStatus)
            //пауза
            if (ElevatorList.Count == 0 && CurrentWeight == 0)
                Wait();
            else if (CurrentWeight == 0)
                GoEmtyToCall();
            else if (ElevatorList[0] > CurrentFloor)
                CarryUp();
            else
                CarryDown();
        }
        private void CarryUp()
        {
            Status = "Carry up";
            UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setElevatorStatus)
            DataBase.direction = -1;
            while (CurrentFloor != ElevatorList[0])
            {
                CurrentFloor -= DataBase.direction;
                MoveFloor?.Invoke();        //подписана SimulationForm (moveFloor)
                CarryFloor?.Invoke();       //подписаны все люди в лифте (Addfloor)
            }
            Stand();
        }
        private void CarryDown()
        {
            Status = "Carry down";
            UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setElevatorStatus)
            DataBase.direction = 1;
            while (CurrentFloor != ElevatorList[0])
            {
                CurrentFloor -= DataBase.direction;
                MoveFloor?.Invoke();        //подписана SimulationForm (moveFloor)
                CarryFloor?.Invoke();       //подписаны все люди в лифте (Addfloor)
            }
            Stand();
        }
        private void Wait()
        {
            Status = "Standby mode";
            UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setElevatorStatus)
        }
        public void Transported(Person person)
        {
            PersonsList.Remove(person);
            CurrentWeight -= person.GetWeight();
            NumTransported++;
            TotalWeight += person.GetWeight();
            CarryFloor -= person.Addfloor;
            UpdateTransported?.Invoke();    //подписана SimulationForm (setNumTransported)
        }
    }
}