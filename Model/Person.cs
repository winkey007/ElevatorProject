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
        }

        private Time BirthdayTime = new Time();
        private int BirthdayFloor;
        private int DestinationFloor;
        private int Id;
        private int CurrentFloor;
        private float Weight;
        private string Status;

        public event Func<bool> Alone;
        public event Func<int> CheckFloor;
        public event Action EventCloseDoor;
        public event Action<string> UpdateStatus;
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
        public void setStatus(string status)
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
            this.UpdateStatus?.Invoke(Status);
            UpdateElevatorList?.Invoke(BirthdayFloor,Status);
        }
        public void EnterTheElevator(int floor)
        {
            if(CurrentFloor==floor && Status == "Called the elevator")
            {
                Status = "Entered the elevator";
                UpdateStatus?.Invoke(Status);
                if (!Entered(this, DestinationFloor))
                    ChooseFloor();
                Check();
            }
            //задержка
        }
        private void Check()
        {
            if (!Alone.Invoke())
                CloseDoor();
        }
        public bool Answer()
        {
            return CurrentFloor == CheckFloor?.Invoke() && Status == "Called the elevator";
        }
        private void ChooseFloor()
        {
            Status = "Chose floor";
            UpdateStatus?.Invoke(Status);
            UpdateElevatorList?.Invoke(DestinationFloor,Status);
            //задержка
        }
        private void CloseDoor()
        {
            Status = "Closed the doors";
            UpdateStatus?.Invoke(Status);
            //задержка
            //лифт закрывает двери
            EventCloseDoor?.Invoke();
        }
        public void GetOffTheElevator(int floor)
        {
            if(DestinationFloor == floor && Status == "Entered the elevator" || Status == "Closed the doors")
            {
                Status = "Ger off the elevator";
                UpdateStatus?.Invoke(Status);
                Transported?.Invoke(this);
            }
        }
        public void Addfloor()
        {
            CurrentFloor -= DataBase.direction;
        }
    }

}