using System;
using System.Collections.Generic;
using System.Text;

namespace TimeDiffFunction
{
    public class TimeFunction
    {
        public static (int, int) TimeBetween(int hour1, int minute1, int hour2, int minute2)
        {
            if((hour1 - hour2) > 0)
            {
                return (hour1 - hour2, minute1 - minute2);
            }
            else
            {
                return minute1 - minute2;
            }
        }
    }
}
