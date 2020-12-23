using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hash
{
    class Stackkk
    {
        static void Main()
        {
            Stack MyStack = new Stack();
            ArrayList arr = new ArrayList();
            arr.Add(12);
            arr.Add(23);
            arr.Add(36);
            Stack brr = new Stack(arr);
            Console.WriteLine(brr.Count);
            Console.WriteLine(brr.Contains(23));
            brr.Push(45);
            int x = (int)brr.Pop();
            Console.WriteLine(x);
            int y = (int)brr.Pop();
            Console.WriteLine(y);
            Queue aa = new Queue();
            aa.Enqueue("An");
            aa.Enqueue("B");
            aa.Enqueue("C");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(aa.Dequeue());
            }
            Console.WriteLine(aa.Count);
        } 
    }
}
