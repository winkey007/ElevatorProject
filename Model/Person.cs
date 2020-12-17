using System;
using System.Collections.Generic;
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
            Weight = random.Next(DataBase.MinPersonWeight, DataBase.MaxPersonWeight);
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
        public event Action UpdateWeight;
        public event Action<string> UpdateCurrentFloor;
        public event Action<int,string> UpdateElevatorList;
        public event Func<Person,int,bool> Entered;
        public event Action<int, int, bool> UpdateFloorList;
        public event Action<Person> Transported;

        public void CallTheElevator()
        {
            Status = "Called the elevator";
            if (DataBase.CurrentId == Id)
                UpdateStatus?.Invoke(Status);                
            UpdateElevatorList?.Invoke(BirthdayFloor,Status); 
        }
        public void EnterTheElevator(int floor, Elevator elevator)
        {
            if (CurrentFloor != floor || Status != "Called the elevator" ||
                elevator.CurrentWeight > DataBase.MaxElevatorWeight) return;
            Status = "Entered the elevator";
            UpdateWeight?.Invoke();
            if (DataBase.CurrentId == Id)
                UpdateStatus?.Invoke(Status);     
            UpdateFloorList?.Invoke(CurrentFloor,Id,false);
            Thread.Sleep(1000);
            if (Entered != null && !Entered(this, DestinationFloor))
                ChooseFloor();
            Check();
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
            if (DestinationFloor != floor || (Status != "Moving up" && Status != "Moving down")) return;
            Status = "Get off the elevator";
            UpdateWeight?.Invoke();
            if (DataBase.CurrentId == Id)
                UpdateStatus?.Invoke(Status); 
            UpdateFloorList?.Invoke(CurrentFloor, Id, true);
            Transported?.Invoke(this);
            DataBase.GetOffPersons.Add(new GetOffPerson(Id,50));
            Thread.Sleep(1000);
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