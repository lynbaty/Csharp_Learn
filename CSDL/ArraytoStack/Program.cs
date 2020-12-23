using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraytoStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tao mang co n phan tu \n Nhap n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            NhapMang(array);
            Console.WriteLine("Nhap capaty cua Stack: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Stack MyStack = new Stack(size);

            NhapStack(array ,ref MyStack, size);

            ShowStack(MyStack);


        }

        private static void ShowStack(Stack myStack)
        {
            Stack a = myStack;
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a.Pop());
            }
        }

        private static void NhapStack(int[] array, ref Stack myStack, int size)
        {
            int i = 0;
            
            while(i < array.Length)
            {
                myStack.Push(array[i]);
                i++;
                if (myStack.Count > size)
                {
                    Console.WriteLine("Stack da full");
                    break;
                }
            }    
        }

        static void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i}");
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
        }
       
        
    }
}
