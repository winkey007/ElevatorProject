using System;
using System.Threading;

namespace ElevatorProject.Model
{
    public class Person
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
            BirthdayTime.Ms = DataBase.Time.Ms;           BirthdayTime.Sec = DataBase.Time.Sec;
            BirthdayTime.Min = DataBase.Time.Min;         BirthdayTime.H = DataBase.Time.H;
            Status = "Created";
            Id = id;
            CurrentFloor = BirthdayFloor;
        }

        public Time BirthdayTime = new Time();
        public int BirthdayFloor { set; get; }
        public int DestinationFloor { set; get; }
        public int Id { set; get; }
        public int CurrentFloor { set; get; }
        public float Weight { set; get; }
        public string Status { set; get; }

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
            UpdateStatus?.Invoke(Status);                
            UpdateElevatorList?.Invoke(BirthdayFloor,Status); 
        }
        public void EnterTheElevator(int floor)
        {
            if(CurrentFloor == floor && Status == "Called the elevator")
            {
                Status = "Entered the elevator";
                UpdateStatus?.Invoke(Status);         
                Thread.Sleep(3000);
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
            UpdateStatus?.Invoke(Status);                          
            Thread.Sleep(2000);
            UpdateElevatorList?.Invoke(DestinationFloor,Status);
        }
        private void CloseDoor()
        {
            Status = "Closed the doors";
            UpdateStatus?.Invoke(Status);
            Thread.Sleep(1000);
            DataBase.IsClosed = true;
        }
        public void GetOffTheElevator(int floor)
        {
            if(DestinationFloor == floor && (Status == "Moving up" || Status == "Moving down"))
            {
                Status = "Get off the elevator";
                UpdateStatus?.Invoke(Status);   
                Transported?.Invoke(this);      
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