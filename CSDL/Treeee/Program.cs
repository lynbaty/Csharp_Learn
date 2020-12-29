using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treeee
{
    class Program
    {     
        static void Main(string[] args)
        {
            Node x = new Node();
            Node a = new Node(100);
            x.Add(a, 99);
            x.Add(a, 100);





            Console.WriteLine(a.Height());
            a.Show(a.Root);
            Console.WriteLine(a.Data);
            Console.WriteLine(a.GetLeft==null);





        }
    }
}
