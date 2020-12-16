using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ElevatorProject.Model
{
    public class Elevator
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

        public const int MaxWeight = 400;
        public float TotalWeight { set; get; }
        public int CurrentWeight { set; get; }
        public int NumIdleTransport { set; get; }
        public int NumTransported { set; get; }
        public string Status { set; get; }
        public int CurrentFloor { set; get; }
        public int FloorsInTheDirection { set; get; }
        public List<int> ElevatorList = new List<int>();
        public List<Person> PersonsList = new List<Person>();
        public Time StandTime = new Time();

        public event Action<string> EventUpdateElevatorList;
        public event Action<string> UpdateStatus;
        public event Action MoveFloor;
        public event Action AddFloor;
        public event Action CarryFloor;
        public event Action<int> EventOpenDoors;
        public event Action<int> UpdateTransported;
        public event Action<int> AddFloorList;
        public event Action<int, int, bool> UpdateFloorList;

        public int GetCurrentFloor()
        {
            return CurrentFloor;
        }
        public Result SendResult(Result result)
        {
            result.NumIdleTransport = NumIdleTransport;
            result.NumTransported = NumTransported;
            result.TotalWeight = TotalWeight;
            return result;
        }
        public void UpdateElevatorList(int floor, string status)
        {
            bool flag = false;
                if (!ElevatorList.Any())
                {
                    ElevatorList.Add(floor);
                    FloorsInTheDirection++;
                   // AddFloorList?.Invoke(floor);
                    EventUpdateElevatorList?.Invoke(String.Join(" ", ElevatorList));
                    if (status == "Called the elevator")
                    {
                        GoEmtyToCall();
                    }
                }
                else
                {
                    if (CurrentFloor == floor && ElevatorList[0] != floor && Status != "Signal Overload")
                    {
                        ElevatorList.Insert(0, floor);
                        FloorsInTheDirection++;
                    }
                    else
                    {
                        switch ((Math.Sign(CurrentFloor - ElevatorList[0]) == Math.Sign(CurrentFloor - floor)) || (Math.Sign(CurrentFloor - ElevatorList[0]) == 0 && ElevatorList.Count > 1 && Math.Sign(CurrentFloor - ElevatorList[1]) == Math.Sign(CurrentFloor - floor)))
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

                                    if (Math.Abs(CurrentFloor - ElevatorList[i]) == Math.Abs(CurrentFloor - floor))
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
                                        if (Math.Abs(ElevatorList[FloorsInTheDirection - 1] - ElevatorList[i]) > Math.Abs(ElevatorList[FloorsInTheDirection - 1] - floor))
                                        {
                                            ElevatorList.Insert(i, floor);
                                            flag = true;
                                            break;
                                        }

                                        if (ElevatorList[i] == floor)
                                        {
                                            flag = true;
                                            break;
                                        }
                                    }
                                    if (!flag)
                                        ElevatorList.Insert(ElevatorList.Count, floor);
                                }
                                break;
                        }
                 //   AddFloorList?.Invoke(floor);
                    EventUpdateElevatorList?.Invoke(String.Join(" ", ElevatorList));
                    }
                    
                }

        }
        private void GoEmtyToCall()
        {
            Status = "Go emty to call";
            UpdateStatus?.Invoke(Status);
            NumIdleTransport++;
            if (ElevatorList[0] > CurrentFloor)
                DataBase.Direction = -1;
            else
                DataBase.Direction = 1;
            while (CurrentFloor != ElevatorList[0])
            {
                CurrentFloor -= DataBase.Direction;
                MoveFloor?.Invoke();
                Thread.Sleep(3000);
            }
            Stand();
        }
        private void Stand()
        {
            Status = "Stand";
            UpdateStatus?.Invoke(Status);
            Thread.Sleep(2500);
            ElevatorList.RemoveAt(0);

            FloorsInTheDirection = FloorsInTheDirection == 1 ? ElevatorList.Count : FloorsInTheDirection-1;

            EventUpdateElevatorList?.Invoke(String.Join(" ", ElevatorList));
            OpenDoors();
        }
        private void OpenDoors()
        {
            Status = "Open doors";
            UpdateStatus?.Invoke(Status);
            Thread.Sleep(2500);
            CheckMode();
        }
        public bool AddTime(Person person, int floor)
        {
            StandTime = StandTime + (new Time(0, 1, 0, 0));
            PersonsList.Add(person);
            CurrentWeight += person.Weight;
            CarryFloor += person.UpdateStatusFromElevator;
            EventOpenDoors += person.GetOffTheElevator;
            EventOpenDoors -= person.EnterTheElevator;
            AddFloor += person.AddFloor;
            return ElevatorList.Exists(x => x == floor);
        }
        private void CheckMode()
        {
            DataBase.IsClosed = false;
            StandTime = new Time(0, 2, 0, 0);
            Status = "Check mode";
            UpdateStatus?.Invoke(Status);
            if(!DataBase.Overload)
                EventOpenDoors?.Invoke(CurrentFloor);
            UpdateTransported?.Invoke(CurrentWeight);
            if (DataBase.IsClosed && CurrentWeight >= MaxWeight)
            {
                DataBase.IsClosed = false;
                Signal();
            }
            else if(!DataBase.IsClosed)
            {
                DataBase.Overload = false;
                Thread.Sleep(StandTime.Sec*1000);
            }
            CloseDoors();
        }
        private void Signal()
        {
            Status = "Signal Overload";
            UpdateStatus?.Invoke(Status);
            Thread.Sleep(2500);
            while (CurrentWeight > MaxWeight)
            {
                CurrentWeight -= PersonsList[PersonsList.Count - 1].Weight;
                PersonsList[PersonsList.Count - 1].Status = "Get off the elevator";
                Thread.Sleep(1000);
                PersonsList[PersonsList.Count - 1].Status = "Called the elevator";
                UpdateElevatorList(CurrentFloor, PersonsList[PersonsList.Count - 1].Status);
                CarryFloor -= PersonsList[PersonsList.Count - 1].UpdateStatusFromElevator;
                AddFloor -= PersonsList[PersonsList.Count - 1].AddFloor;
                EventOpenDoors -= PersonsList[PersonsList.Count - 1].GetOffTheElevator;
                EventOpenDoors += PersonsList[PersonsList.Count - 1].EnterTheElevator;
                PersonsList.RemoveAt(PersonsList.Count - 1);
                UpdateFloorList?.Invoke(PersonsList[PersonsList.Count - 1].CurrentFloor, PersonsList[PersonsList.Count - 1].Id, true);
            }

            DataBase.IsClosed = false;
            DataBase.Overload = true;
            CheckMode();
        }
        public void CloseDoors()
        {
            Status = "Close doors";
            UpdateStatus?.Invoke(Status);
            Thread.Sleep(2500);
            UpdateTransported?.Invoke(CurrentWeight);
            if (ElevatorList.Count == 0 && CurrentWeight == 0)
                Wait();
            else if (CurrentWeight == 0)
                GoEmtyToCall();
            else if (ElevatorList[0] > CurrentFloor)
                CarryUp();
            else if(ElevatorList[0] < CurrentFloor)
                CarryDown();
        }
        private void CarryUp()
        {
            Status = "Carry up";
            UpdateStatus?.Invoke(Status);
            DataBase.Direction = -1;
            while (CurrentFloor != ElevatorList[0])
            {
                CurrentFloor -= DataBase.Direction;
                CarryFloor?.Invoke(); 
                MoveFloor?.Invoke();       
                Thread.Sleep(3000);
                AddFloor?.Invoke();
            }
            Stand();
        }
        private void CarryDown()
        {
            Status = "Carry down";
            UpdateStatus?.Invoke(Status);
            DataBase.Direction = 1;
            while (CurrentFloor != ElevatorList[0])
            {
                CurrentFloor -= DataBase.Direction;
                CarryFloor?.Invoke();       
                MoveFloor?.Invoke();        
                Thread.Sleep(3000);
                AddFloor?.Invoke();
            }
            Stand();
        }
        private void Wait()
        {
            Status = "Standby mode";
            UpdateStatus?.Invoke(Status);
        }
        public void Transported(Person person)
        {
            PersonsList.Remove(person);
            CurrentWeight -= person.Weight;
            NumTransported++;
            TotalWeight += person.Weight;
            CarryFloor -= person.UpdateStatusFromElevator;
            AddFloor -= person.AddFloor;
            EventOpenDoors -= person.GetOffTheElevator;
            UpdateTransported?.Invoke(CurrentWeight); 
        }
    }
}