using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seaching
{
    class Khongdequy
    {
        static void Main()
        {
            int[] a = new int[] { 1, 3, 4, 2, 7, 8, 9,28,23,34,55,12,34,10 };
            Console.WriteLine("Nhap gia tri x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Array.Sort(a);
            Hienmang(a);
            Console.WriteLine(Searchk(a,x));
            Console.WriteLine(SeachTT(a, x));

        }

        private static int SeachTT(int[] a, int x)
        {
            if(x< a[0]||x>a[a.Length-1])
            {
                return -1;
            }    
            int i = 0;
            while (x >= a[i])
            {
                if (x == a[i])
                {
                    return i;
                }
                i++;
            }
            return -1;

        }

        private static int Searchk(int[] a, int x)
        {
            int first = 0;
            int last = a.Length - 1;
            return Searchkdq(a, first, last, x);

        }

        private static int Searchkdq(int[] a, int first, int last, int x)
        {
            if(x< a[0] || x > a[last])
            {
                return -1;
            }    
            while (first <= last)
            {
                int Mid = (first + last) / 2;
                if (a[Mid] == x)
                {
                    return Mid;
                    break;
                }
                if (x < a[Mid])
                {
                    last = Mid - 1;
                }
                if (x > a[Mid])
                {
                    first = Mid + 1;
                }
            }
            return -1;

        }

        private static void Hienmang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
