using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advan
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string n, int a)
        {
            this.Name = n;
            this.Age = a;
        }
        public override string ToString()
        {
            return "Name: " + Name + " .Age: " + Age;

        }

    }
}
