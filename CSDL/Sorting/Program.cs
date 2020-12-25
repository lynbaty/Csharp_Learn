using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[] { 12, 23, 45, 22, 1, 34, 56, 87, 45, 32, 45, 23, 37 };

            //SortBuble(ref a);

            Show(a);
            MergeSort(a);
            //InsertSort(a);
            Show(a);
            int[] c = RecMergeSort(ref a, 0, 1, 2, 3);
            Show(c);


        }

        private static int[] RecMergeSort(ref int[] a, int x1, int y1, int x2, int y2)
        {
            int [] b = new int[a.Length];
            int l = x1;
            int l1 = x1;
            int l2 = y1;
            while (l<=y2)
            {
                b[l] = Math.Min(a[l1], a[l2]);
                if(Math.Min(a[l1], a[l2])==a[l1])
                {
                    l1++;
                    l++;
                }else
                {
                    l2++;
                    l++;
                }    

            }
            return b;
  
                    
        }




        private static void MergeSort(int[] a)
        {
            int k = 0;
            int x = a.Length / 2;
            for (int i = 0; i < a.Length/2; i++)
            {
                if (a[2*i] > a[2*i + 1])
                {
                    SwitchSort(ref a[2*i], ref a[2*i + 1]);
                }    
            
            }
            

            
            
        }

        private static void InsertSort(int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (a[i+1]<= a[j])
                    {
                        int x = a[i + 1];
                        for (int k = i; k >= j; k--)
                        {
                            a[k + 1] = a[k];
                        }
                        a[j] = x;
                        break;
                    }
                }
            }
        }

        private static int[] Chen(ref int[] a, int x)
        {
            int[] b = new int[a.Length + 1];
            if (x >= a[a.Length - 1])
            {
                b[a.Length] = x;
                for (int i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }
            }
            else
            {
                int k = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (x <= a[i])
                    {
                        k = i;
                        break;
                    }
                }
                for (int i = 0; i < k; i++)
                {
                    b[i] = a[i];
                }
                for (int i = k; i < a.Length; i++)
                {
                    b[i+1] = a[i];
                }
                b[k] = x;
            }
            return b;
        }


        private static void LinerSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < a[i])
                    {
                        SwitchSort(ref a[i], ref a[j]);
                    }
                }
            }
        }

        private static void StickSort(int[] a)
        {
            for (int i = 0; i <  a.Length; i++)
            {
                SwitchSort(ref a[Min(a, i)], ref a[i]);
            }
        }
        private static int Min(int[] a ,int x)
        {
            int min = x;
            for (int i = x ; i < a.Length; i++)
            {
                if (a[i] < a[min])
                {
                    min = i;
                }
            }
            return min;
        }

        //private static void SortPH(int[] a)
        //{
        //    int first = 0;
        //    int last = a.Length - 1;
        //    RecSort(a, first, last);

        //}

        //private static void RecSort(int[] a, int first, int last)
        //{
        //    if(first>=last)
        //    {
        //        return;
        //    }    
        //    int i = first;
        //    int j = last;
        //    int x = a[(first + last) / 2];
        //    while (i<j)
        //    {
        //        if (a[i] >= x && a[j]>= x)
        //        {
        //            j--;
        //        }
        //        else if (a[i] >= x && a[j]<x)
        //        {
        //            SwitchSort(ref a[i],ref a[j]);
        //        }
        //        else if (a[i] <x && a[j]<x)
        //        {
        //            i++;
        //        }else
        //        {
        //            i++;
        //            j--;
        //        }    
        //    }
        //   RecSort(a, first, j);
        //   RecSort(a, i, last);
        //   return;

        //}

        private static void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+"\t");
            }
            Console.WriteLine();
        }

        private static void SortBuble(ref int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = 0; j < a.Length - i -1; j++)
                {
                    if (a[j]>a[j+1])
                    {
                        SwitchSort(ref a[j],ref a[j + 1]);
                    }
                }
            }
        }
        private static void SwitchSort(ref int v1,ref int v2)
        {
            int x = v2;
            v2 = v1;
            v1 = x;
        }
    }
}
