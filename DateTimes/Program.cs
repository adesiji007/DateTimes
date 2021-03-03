using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
  class Time
    {
        // private member variables
        int Year;
        int Month;
        int Date;
        int Hour;
        int Minute;
        int Second;
        double millisecs;
       public void DisplayCurrentTime()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", Year, Month, Date, Hour, Minute, Second, millisecs);
        } 
        public Time (System.DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
            millisecs = dt.Millisecond;

        }
        public  static DateTime ToLocalDateFromEpoch(Double millisecs)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
            return dateTime.ToLocalTime().AddMilliseconds(millisecs);
        }
        public static long ToEpoch(this DateTime date)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return Convert.ToInt64((date - dateTime).TotalSeconds);
        }

        static void Main(string[] args)
        {

            System.DateTime CurrentTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            Time t = new Time(CurrentTime);
            t.DisplayCurrentTime();
             Console.ReadKey();
            
        }
    
    }
}
