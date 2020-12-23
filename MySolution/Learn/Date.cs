using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Date
    {
        public int Year;
        public int Month;
        public int Day;
        public Date()
        {
            Year = 1900;
            Month = 1;
            Day = 1;
        }
        public Date(int D, int M, int Y)
        {
            this.Year = Y;
            this.Month = M;
            this.Day = D;
        }
        public Date(Date a)
        {
            this.Year = a.Year;
            this.Month = a.Month;
            this.Day = a.Day;
        }
        public Date(System.DateTime dt)
        {
            this.Year = dt.Year;
            this.Month = dt.Month;
            this.Day = dt.Day;
        }
        public void Show()
        {
            Console.WriteLine($"{this.Day}/{this.Month}/{this.Year}");
        }
    }
}
