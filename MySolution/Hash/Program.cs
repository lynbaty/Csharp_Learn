using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable MyHash = new Hashtable();
            MyHash.Add("A", new Ani("Meo", 12));
            MyHash.Add("B", new Ani("Vinh", 20));
            Console.WriteLine(MyHash.Count);
            foreach (string item in MyHash.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (Ani item in MyHash.Values)
            {
                item.Show();
            }

            Console.WriteLine(MyHash.ContainsKey("A"));
            foreach (DictionaryEntry item in MyHash)
            {
                Console.WriteLine($"{item.Key} & {item.Value}");
            }
            Console.WriteLine(MyHash["A"]);
  
           


            Console.ReadLine();


        }
    }
    public class Ani
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public Ani(string n, int a)
        {
            this.Name = n;
            this.Age = a;
        }
        public void Show()
        {
            Console.WriteLine($"Name: {this.Name} & Age: {this.Age}");
        }
        

    }
}
