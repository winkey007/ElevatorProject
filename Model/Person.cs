using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElevatorProject.Model
{
    class Person
    {
        public Person(int id)
        {
            Random rnd = new Random();
            BirthdayFloor = rnd.Next(1, DataBase.NumFloors);
            DestinationFloor = rnd.Next(1, DataBase.NumFloors);
            while (DestinationFloor == BirthdayFloor)
            {
                DestinationFloor = rnd.Next(1, DataBase.NumFloors);
            }
            Weight = rnd.Next(40, 100);
            BirthdayTime.setMs(DataBase.time.getMs());           BirthdayTime.setSec(DataBase.time.getSec());
            BirthdayTime.setMin(DataBase.time.getMin());         BirthdayTime.setH(DataBase.time.getH());
            Status = "Created";
            Id = id;
            CurrentFloor = BirthdayFloor;
            //CallTheElevator();
        }

        private Time BirthdayTime = new Time();
        private int BirthdayFloor;
        private int DestinationFloor;
        private int Id;
        private int CurrentFloor;
        private float Weight;
        private string Status;

        public event Action Alone;
        public event Func<int> CheckFloor;
        public event Action EventCloseDoor;
        public event Action<string> UpdateStatus;
        public event Action<string> UpdateCurrentFloor;
        public event Action<int,string> UpdateElevatorList;
        public event Func<Person,int,bool> Entered;
        public event Action<Person> Transported;

        public int GetId()
        {
            return Id;
        }
        public float GetWeight()
        {
            return Weight;
        }
        public string GetStatus()
        {
            return Status;
        }
        public int GetCurrentFloor()
        {
            return CurrentFloor;
        }
        public void SetStatus(string status)
        {
            Status = status;
        }
        public Time GetBirthdayTime()
        {
            return BirthdayTime;
        }

        public void CallTheElevator()
        {
            Status = "Called the elevator";
            UpdateStatus?.Invoke(Status);                //подписана SimulationForm (setPersonStatus)
            UpdateElevatorList?.Invoke(BirthdayFloor,Status); //подписан лифт (updateElevatorList)
        }
        public void EnterTheElevator(int floor)
        {
            if(CurrentFloor == floor && Status == "Called the elevator")
            {
                Status = "Entered the elevator";
                UpdateStatus?.Invoke(Status);         //подписана SimulationForm (setPersonStatus)
                Thread.Sleep(3000);
                if (!Entered(this, DestinationFloor)) //подписан лифт (AddTime)
                    ChooseFloor();
                Check();
            }
        }
        private void Check()
        {
            DataBase.isEmpty = false;
            Alone?.Invoke(); //подписаны все люди, кроме вызывающего (Answer)
            if (!DataBase.isEmpty)
                CloseDoor();
        }
        public void Answer()
        {
            if (CurrentFloor == CheckFloor?.Invoke() && Status == "Called the elevator") //подписан лифт (getCurrentFloor)
                DataBase.isEmpty = true;
        }
        private void ChooseFloor()
        {
            Status = "Chose floor";
            UpdateStatus?.Invoke(Status);                           //подписана SimulationForm (setPersonStatus)
            Thread.Sleep(2000);
            UpdateElevatorList?.Invoke(DestinationFloor,Status);    //подписан лифт (updateElevatorList)
            //задержка
        }
        private void CloseDoor()
        {
            Status = "Closed the doors";
            UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setPersonStatus)
            Thread.Sleep(2000);
            EventCloseDoor?.Invoke();       //подписан лифт (CloseDoors)
        }
        public void GetOffTheElevator(int floor)
        {
            if(DestinationFloor == floor && (Status == "Moving up" || Status == "Moving down"))
            {
                Status = "Ger off the elevator";
                UpdateStatus?.Invoke(Status);   //подписана SimulationForm (setPersonStatus)
                Transported?.Invoke(this);      //подписан лифт (Transported)
            }
        }
        public void UpdateStatusFromElevator()
        {
            if (DataBase.direction == -1)
                Status = "Moving up";
            else
                Status = "Moving down";
            if (DataBase.CurrentId == Id)
                UpdateStatus?.Invoke(Status);
        }

        public void Addfloor()
        {
            CurrentFloor -= DataBase.direction;
            if (DataBase.CurrentId == Id)
                UpdateCurrentFloor?.Invoke(CurrentFloor.ToString());
        }
    }

}