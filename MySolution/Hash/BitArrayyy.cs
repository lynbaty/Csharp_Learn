using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hash
{
    class BitArrayyy
    {
        static void Main()
        {
            bool[] aa = new bool[5] { false, true, true, true, false };
            BitArray bb = new BitArray(aa);
            Console.WriteLine(bb.Count);
            Console.WriteLine(bb.Length);
            bb.Length = 8;
            Console.WriteLine(bb.Length);
            Show(bb);

            BitArray cc = bb.Not();
            Show(cc);
            Show(bb);

            void Show(BitArray x)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Console.Write(x.Get(i) + " ");
                }
                Console.WriteLine();
            }
            int a = 2, b = 4;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Gene<int> xxx = new Gene<int>(5);
            xxx.Setvalue(0, 24);
            xxx.Setvalue(1, 35);
            xxx.Setvalue(2, 45);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(xxx.Getvalue(i));
            }


            
        }
        public static void Swap<T> ( ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

    }
    public class Gene<T>
    {
        public T[] Items { get; set; }
        public Gene(int size)
        {
            Items = new T[size];
        }
        public T Getvalue(int Index)
        {
            return Items[Index];

        }
        public void Setvalue(int Index, T Value)
        {
            Items[Index] = Value;
        }

    }    
}
