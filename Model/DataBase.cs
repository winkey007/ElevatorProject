using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.Model
{
    static class DataBase
    {
        public static int NumPersons;
        public static int NumFloors;
        public const int PathLength = 500;
        public static int FloorLength;
        public static int direction;
        public const int HeightFloor = 25;
        public static int CurrentHeight;
        public static int TimeCurrentPerson;
        public static Time time = new Time();
        public static int id;
        public static int CurrentId;
        public static bool isEmpty;
    }
}
