using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Time
    {
        int Year;
        int Month;
        int Date;
        int Hour;
        int Minute;
        int Second = 30;
        public void DisplayCurrentTime()
        {
            Console.WriteLine($"Current time is: {Month}/{Date}/{Year} {Hour}:{Minute}:{Second}");
        }
        public Time(System.DateTime dt)
        {
            Console.WriteLine("Ham contructor tu dong goi!");
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;

        }
        public Time(Time a)
        {
            this.Year = a.Year;
            this.Month = a.Month;
            this.Date = a.Date;
            this.Hour = a.Hour;
            this.Minute = a.Minute;
            this.Second = a.Second;
        }
    }
}
