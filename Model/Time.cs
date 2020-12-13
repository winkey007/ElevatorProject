namespace ElevatorProject.Model
{
    public class Time
    {
        public Time(int ms, int sec, int min, int h)
        {
            Ms = ms;
            Sec = sec;
            Min = min;
            H = h;
        }
        public Time(Time time)
        {
            Ms = time.Ms;
            Sec = time.Sec;
            Min = time.Min;
            H = time.H;
        }
        public Time()
        {
            Ms = 0;
            Sec = 0;
            Min = 0;
            H = 0;
        }

        public int Ms { get; set; }
        public int Sec { get; set; }
        public int Min { get; set; }
        public int H { get; set; }

        
        public static bool operator <(Time time1, Time time2)
        {
            if (time1.H < time2.H)
                return true;
            if (time1.H > time2.H)
                return false;
            if (time1.Min < time2.Min)
                return true;
            if (time1.Min > time2.Min)
                return false;
            if (time1.Sec < time2.Sec)
                return true;
            if (time1.Sec > time2.Sec)
                return false;
            if (time1.Ms < time2.Ms)
                return true;
            return false;
        }
        public static bool operator >(Time time1, Time time2)
        {
            if (time1.H > time2.H)
                return true;
            if (time1.H < time2.H)
                return false;
            if (time1.Min > time2.Min)
                return true;
            if (time1.Min < time2.Min)
                return false;
            if (time1.Sec > time2.Sec)
                return true;
            if (time1.Sec < time2.Sec)
                return false;
            if (time1.Ms > time2.Ms)
                return true;
            return false;
        }
        public static Time operator +(Time time1, Time time2)
        {
            return (new Time(time1.Ms + time2.Ms, time1.Sec + time2.Sec, time1.Min + time2.Min, time2.H + time1.H));
        }
        public static Time operator -(Time time1, Time time2)
        {
            Time time = new Time();
        
            if(time1.Ms < time2.Ms)
            {
                time.Sec--; time.Ms += 10;
            }
            time.Ms += time1.Ms - time2.Ms;
            if (time1.Sec < time2.Sec)
            {
                time.Min--; time.Sec += 60;
            }
            time.Sec += time1.Sec - time2.Sec;
            if (time1.Min < time2.Min)
            {
                time.H--; time.Min += 60;
            }
            time.Min += time1.Min - time2.Min;
            time.H += time1.H - time2.H;
            return time;
        }
    }
}
