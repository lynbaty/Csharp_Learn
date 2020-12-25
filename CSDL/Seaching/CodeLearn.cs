using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seaching
{
    class CodeLearn
    {
        static void Main ()
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Seach(a,x));
        
        }

        private static int Seach(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (x == a[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
