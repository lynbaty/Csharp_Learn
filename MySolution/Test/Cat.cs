using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Cat
    {
        public string Petname;
        public int age;
        public float weight;
        public string color;

        public Cat()
        {
            Petname = "Tom";
            age = 4;
            weight = 5.0f;
            color = "black";

        }
        public void Sleep()
        {
            Console.WriteLine(Petname + "sleeping" );
        }
        public void Eat()

        {
            Console.WriteLine(Petname + "Eating fish");
        }
    }
}
