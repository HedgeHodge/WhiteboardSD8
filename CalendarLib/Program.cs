using System;

namespace CalendarLib
{
    class Program
    {
        public static int getJulianDate ( DateTime date )
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            bool isLeap = DateTime.IsLeapYear(year);

            int julianDate = 0;

            julianDate += day;
            
            switch (month)
            {
                case 1:
                    julianDate += 31;
                    break;
                case 2:
                    julianDate += 59;
                    break;
                case 3:
                    julianDate += 90;
                    break;
                case 4:
                    julianDate += 120;
                    break;
                case 5:
                    julianDate += 151;
                    break;
                case 6:
                    julianDate += 181;
                    break;
                case 7:
                    julianDate += 212;
                    break;
                case 8:
                    julianDate += 243;
                    break;
                case 9:
                    julianDate += 273;
                    break;
                case 10:
                    julianDate += 304;
                    break;
                case 11:
                    julianDate += 334;
                    break;
                case 12:
                    julianDate += 365;
                    break;
            }
            if (isLeap)
            {
                return julianDate + 1;
            }
            else
            {
                return julianDate;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(getJulianDate(new DateTime(2020, 05, 03)));
        }
    }
}
