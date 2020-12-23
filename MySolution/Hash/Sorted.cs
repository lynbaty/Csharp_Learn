using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hash
{
    class Sorted
    {
        static void Main()
        {
            SortedList aa = new SortedList(new PersonComparer());
            aa.Add(new Person("Thien AN", 30),143);
            aa.Add( new Person("Vinh", 29),27);
            aa.Add(new Person("Don", 20), 12);



        
            foreach (Person item in aa.GetKeyList())
            {
                Console.WriteLine(item.ToString());
            }
            foreach (DictionaryEntry item in aa)
            {
                Console.WriteLine($"{item.Key} \t{item.Value}");
            }
        }

        
       

    }
    class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public override string ToString()
        {
            return $"Name: {Name} \t Age: {Age}";
        }
    }
    class PersonComparer: IComparer
    {
        public int Compare(object x, object y)
        {
            Person a = (Person)x;
            Person b = (Person) y;
            if(a == null|| b == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if(a.Age < b.Age)
                {
                    return -1;
                }
                else if (a.Age == b.Age)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
