using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 12345678;
            string str = Convert.ToString(n);
            int[] split;
            Tachso(str, out split);




        }

        static void Tachso(string str, out int[] split)
        {
            split = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                split[i] = Convert.ToInt32(str[i]);
                Console.WriteLine(split[i]);
            }
        }
    }
}
