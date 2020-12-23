using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hash
{
    class List
    {
        static void Main()
        {
            List<int> Mylist = new List<int>();
            List<int> Mylist2 = new List<int>(5);
            Mylist.Insert(0, 12);
            //dictionary gio hashtable => key value dang list. 
            Dictionary<string, string> MyDic = new Dictionary<string, string>(5);
            var An = Tuple.Create<string, int, int>("An", 24, 10);
            var An2 = new Tuple<string, int>("Diem", 9);
            Console.WriteLine(An.Item1);
            Console.WriteLine(An2.Item2);
            string x = An.Item2.ToString();
            Console.WriteLine(x);


        }
    }
}
