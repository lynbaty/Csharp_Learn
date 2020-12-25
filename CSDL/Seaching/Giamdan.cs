using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seaching
{
    class Giamdan
    {
        static void Main()
        {
            int[] a = new int[1000] ;
            Nhap(a);
            Array.Sort(a);
            Array.Reverse(a);
            Show(a);
            Console.WriteLine("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SeachDQ(a, x));
            int y = SeachKDQ(a, x);
            Console.WriteLine(y);

        }

        private static void Nhap(int[] a)
        {
            Random x = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = x.Next(1,10000) ;
            }
        }

        private static int SeachKDQ(int[] a, int x)
        {
            int first = 0;
            int last = a.Length - 1;
            if (x > a[first] || x < a[last])
            {
                return -1;
            }
            while(first <= last)
            {
                int mid = (first + last) / 2;
                if (x== a[mid])
                {
                    return mid;
                }
                else if (x > a[mid])
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
            return -1;
        }

        private static void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        private static int SeachDQ(int[] a, int x)
        {
            if (x < a[a.Length - 1]|| x>a[0])
            {
                return -1;
            }
            int first = 0;
            int last = a.Length - 1;
            return SeachDQRec(a, first, last, x);
        }

        private static int SeachDQRec(int[] a, int first, int last, int x)
        {
            int Mid = (first + last) / 2;
            if (first > last)
            {
                return -1;
            }
            if (x == a[Mid])
            {
                return Mid;
            }
            else if (x > a[Mid])
            {
                return SeachDQRec(a, first, Mid - 1, x);
            }
            else
            {
                return SeachDQRec(a, Mid + 1, last, x);
            }
        }

    }
}
