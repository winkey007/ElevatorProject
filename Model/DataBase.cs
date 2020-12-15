namespace ElevatorProject.Model
{
    static class DataBase
    {
        public static int NumPersons;
        public static int NumFloors;
        public const int PathLength = 711;
        public static int FloorLength;
        public static int Direction;
        public const float Scaller = 1.39f;
        public const int HeightFloor = 25;
        public static int CurrentHeight;
        public static bool Overload;
        public static Time Time = new Time();
        public static int Id;
        public static int CurrentId;
        public static bool IsEmpty;
        public static bool IsClosed;
    }
}
