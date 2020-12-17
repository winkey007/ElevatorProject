using System.Collections.Generic;

namespace ElevatorProject.Model
{
    static class DataBase
    {
        public static int NumPersons;
        public static int NumFloors;
        public static int MinPersonWeight;
        public static int MaxPersonWeight;
        public static int MaxElevatorWeight;
        public const int PathLength = 690;
        public static int FloorLength;
        public static int Direction;
        public const float Scaller = 1.39f;
        public const int HeightFloor = 25;
        public static int CurrentHeight;
        public static int CurrentLength;
        public static bool Overload;
        public static Time Time = new Time();
        public static List<GetOffPerson> GetOffPersons = new List<GetOffPerson>();
        public static int Id;
        public static int CurrentId;
        public static bool IsEmpty;
        public static bool IsClosed;
    }

    public class GetOffPerson
    {
        public GetOffPerson(int id, int timer)
        {
            Id = id;
            Timer = timer;
        }
        public int Id { get; set; }
        public int Timer { get; set; }
    }
}
