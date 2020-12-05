using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorProject.Model
{
    
    class Time
    {
        public Time(int ms, int sec, int min, int h)
        {
            this.ms = ms;
            this.sec = sec;
            this.min = min;
            this.h = h;
        }
        public Time(Time time)
        {
            this.ms = time.ms;
            this.sec = time.sec;
            this.min = time.min;
            this.h = time.h;
        }
        public Time()
        {
            this.ms = 0;
            this.sec = 0;
            this.min = 0;
            this.h = 0;
        }

        private int ms;
        private int sec;
        private int min;
        private int h;

        public int getMs()
        {
            return ms;
        }
        public int getSec()
        {
            return sec;
        }
        public int getMin()
        {
            return min;
        }
        public int getH()
        {
            return h;
        }
        public void setMs(int ms)
        {
            this.ms = ms;
        }
        public void setSec(int sec)
        {
            this.sec = sec;
        }
        public void setMin(int min)
        {
            this.min = min;
        }
        public void setH(int h)
        {
            this.h = h;
        }
        public static bool operator <(Time time1, Time time2)
        {
            if (time1.h < time2.h)
                return true;
            else if (time1.h > time2.h)
                return false;
            else
            {
                if (time1.min < time2.min)
                    return true;
                else if (time1.min > time2.min)
                    return false;
                else
                {
                    if (time1.sec < time2.sec)
                        return true;
                    else if (time1.sec > time2.sec)
                        return false;
                    else
                    {
                        if (time1.ms < time2.ms)
                            return true;
                        else
                            return false;
                    }
                }
            }
        }
        public static bool operator >(Time time1, Time time2)
        {
            if (time1.h > time2.h)
                return true;
            else if (time1.h < time2.h)
                return false;
            else
            {
                if (time1.min > time2.min)
                    return true;
                else if (time1.min < time2.min)
                    return false;
                else
                {
                    if (time1.sec > time2.sec)
                        return true;
                    else if (time1.sec < time2.sec)
                        return false;
                    else
                    {
                        if (time1.ms > time2.ms)
                            return true;
                        else
                            return false;
                    }
                }
            }
        }
        public static Time operator +(Time time1, Time time2)
        {
            return (new Time(time1.ms + time2.ms, time1.sec + time2.sec, time1.min + time2.min, time2.h + time1.h));
        }
        public static Time operator -(Time time1, Time time2)
        {
            Time time = new Time();
        
            if(time1.ms < time2.ms)
            {
                time.sec--; time.ms += 10;
            }
            time.ms += time1.ms - time2.ms;
            if (time1.sec < time2.sec)
            {
                time.min--; time.sec += 60;
            }
            time.sec += time1.sec - time2.sec;
            if (time1.min < time2.min)
            {
                time.h--; time.min += 60;
            }
            time.min += time1.min - time2.min;
            time.h += time1.h - time2.h;
            return time;
        }
    }
}
