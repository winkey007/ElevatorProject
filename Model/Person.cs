using System;
using System.Threading;

namespace ElevatorProject.Model
{
    public class Person
    {
        public Person(int id)
        {
            BirthdayFloor = random.Next(1, DataBase.NumFloors + 1);
            DestinationFloor = random.Next(1, DataBase.NumFloors + 1);
            while (DestinationFloor == BirthdayFloor)
            {
                DestinationFloor = random.Next(1, DataBase.NumFloors);
            }
            Weight = random.Next(40, 120);
            BirthdayTime.Ms = DataBase.Time.Ms;           BirthdayTime.Sec = DataBase.Time.Sec;
            BirthdayTime.Min = DataBase.Time.Min;         BirthdayTime.H = DataBase.Time.H;
            Status = "Created";
            Id = id;
            CurrentFloor = BirthdayFloor;
        }

        public Time BirthdayTime = new Time();
        public Time DeathTime = new Time();
        public int BirthdayFloor { set; get; }
        public int DestinationFloor { set; get; }
        public int Id { set; get; }
        public int CurrentFloor { set; get; }
        public int Weight { set; get; }
        public string Status { set; get; }
        public static Random random = new Random();

        public event Action Alone;
        public event Func<int> CheckFloor;
        public event Action<string> UpdateStatus;
        public event Action<string> UpdateCurrentFloor;
        public event Action<int,string> UpdateElevatorList;
        public event Func<Person,int,bool> Entered;
        public event Action<Person> Transported;

        public void CallTheElevator()
        {
            Status = "Called the elevator";
            if (DataBase.CurrentId == Id)
                UpdateStatus?.Invoke(Status);                
            UpdateElevatorList?.Invoke(BirthdayFloor,Status); 
        }
        public void EnterTheElevator(int floor)
        {
            if(CurrentFloor == floor && Status == "Called the elevator")
            {
                Status = "Entered the elevator";
                if (DataBase.CurrentId == Id)
                    UpdateStatus?.Invoke(Status);         
                Thread.Sleep(1000);
                if (Entered != null && !Entered(this, DestinationFloor))
                    ChooseFloor();
                Check();
            }
        }
        private void Check()
        {
            DataBase.IsEmpty = false;
            Alone?.Invoke();
            if (!DataBase.IsEmpty)
                CloseDoor();
        }
        public void Answer()
        {
            if (CurrentFloor == CheckFloor?.Invoke() && Status == "Called the elevator")
                DataBase.IsEmpty = true;
        }
        private void ChooseFloor()
        {
            Status = "Chose floor";
            if (DataBase.CurrentId == Id)
                UpdateStatus?.Invoke(Status);                          
            Thread.Sleep(2000);
            UpdateElevatorList?.Invoke(DestinationFloor,Status);
        }
        private void CloseDoor()
        {
            Status = "Closed the doors";
            if (DataBase.CurrentId == Id)
                UpdateStatus?.Invoke(Status);
            Thread.Sleep(1000);
            DataBase.IsClosed = true;
        }
        public void GetOffTheElevator(int floor)
        {
            if(DestinationFloor == floor && (Status == "Moving up" || Status == "Moving down"))
            {
                Status = "Get off the elevator";
                if (DataBase.CurrentId == Id)
                    UpdateStatus?.Invoke(Status);   
                Transported?.Invoke(this);
                Thread.Sleep(5000);
                Status = "Deleted";
                DeathTime = DataBase.Time - BirthdayTime;
                if (DataBase.CurrentId == Id)
                    UpdateStatus?.Invoke(Status);
            }
        }
        public void UpdateStatusFromElevator()
        {
            Status = DataBase.Direction == -1 ? "Moving up" : "Moving down";
            if (DataBase.CurrentId == Id)
                UpdateStatus?.Invoke(Status);
        }
        public void AddFloor()
        {
            CurrentFloor -= DataBase.Direction;
            if (DataBase.CurrentId == Id)
                UpdateCurrentFloor?.Invoke(CurrentFloor.ToString());
        }
    }

}