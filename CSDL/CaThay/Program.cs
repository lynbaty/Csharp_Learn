using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaThay
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate = 0.08;
            double n = 240; //ki han goi lai
            double x = 1800000; //So tien goi hang thang
            double sum = 0;
            double sumrate = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = Math.Pow(1 + rate / 12, n - i);
                sumrate += sum;
            }
            double total = sumrate * x;
            Console.WriteLine($"Tong so tien lanh sau 20 nam neu goi ngan hang: {total}");
            double rate2 = 0.08;
            double n2 = 5; //ki han goi lai
            double x2 = 15000000; //So tien goi hang thang
            double sum2 = 0;
            double sumrate2 = 0;
            for (int i = 1; i <= n2; i++)
            {
                sum2 = Math.Pow(1 + rate, n2- i);
                sumrate2 += sum2;
            }
            double total2= sumrate2* x2;
            Console.WriteLine($"Tong so tien lanh sau 5 nam neu goi ngan hang: {total2}");
            double y = 500000000;
            Console.WriteLine(y/sumrate);
        }
    }
}
