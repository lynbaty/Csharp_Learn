using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seaching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 2, 4, 5, 3, 4, 6, 7, 4, 10, 11 };
            Hienmang(array);

            Array.Sort(array);
            Hienmang(array);

            Console.WriteLine("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine(SearchMang(array,x));
            int y = SearchBi(array, x);
            Console.WriteLine(y);
        }

        private static int SearchMang(int[] array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==x)
                {
                    return i;
                    break;
                }
            }
            return -1;
        }//Phep gan min = 1, max = x. Phep so sanh. Min = 1, max bang = x
        private static void Hienmang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        private static int RecSeachBi(int[] a, int first, int last, int x)
        {
            if(first>last)
            {
                return -1;
            }
            else
            {
                int MID = (first + last) / 2;
                if (a[MID] == x)
                {
                    return MID;
                }
                else if (x < a[MID])
                {
                    return RecSeachBi(a, first, MID - 1, x);
                }
                else
                {
                    return RecSeachBi(a, MID + 1, last, x);
                }
            }    
        }
        private static int SearchBi(int[] a, int x)
        {
            return RecSeachBi(a, 0, a.Length - 1, x);
        }/* so phep gan it nhat. 1, so sanh it nhat 1.
          * so gan nhieu nhat Log2/N + 1.....
          * trung binh
          */

        
    }
}
