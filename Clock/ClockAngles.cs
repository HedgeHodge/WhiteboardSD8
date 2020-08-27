using System;

namespace Clock
{
    public class ClockAngles
    {
        public static int GetAngle (DateTime currentTime)
        {
            int minuteHand = currentTime.Minute;
            int hourHand = currentTime.Hour;

            return minuteHand * 6;
        }
    }
}
