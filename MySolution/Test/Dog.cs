using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Dog
    {
        public string name;
        public int age;
        public static string color;


        static Dog()
        {
            Console.WriteLine("aaaaa");
            color = "black";
        }
        public Dog()
        {
            this.name = "Bob";
            Console.WriteLine(this.name);
        }
    }
}
