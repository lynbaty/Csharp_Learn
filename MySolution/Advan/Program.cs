using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Advan
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrPerson = new ArrayList();
            arrPerson.Add(new Person("Bui Thien An", 30));
            arrPerson.Add(new Person("Nguyen Thi Diem", 35));
            arrPerson.Add(new Person("Bui Van Don", 25));
            //Person objTest = new Person("Bui Thien An", 30);
            ArrayList arr2 = new ArrayList();
            arr2.Add(new Person("Quang Vinh", 29));
            arr2.Add(new Person("Nhan", 28));
            arrPerson.InsertRange(1, arr2);


            Console.WriteLine("Danh sach ban dau: ");
            foreach (Person item in arrPerson)
            {
                Console.WriteLine(item.ToString());
                //Console.WriteLine(arrPerson.Contains(item));
            }

            //bool x = arrPerson.Contains(new Person { Name = "Bui Thien An", Age = 30 });
            //Console.WriteLine(x);
            //Console.WriteLine(arrPerson.IndexOf(objTest));

            //arrPerson.Clear();
            foreach (Person item in arrPerson)
            {
                Console.WriteLine(item.ToString());
            }

            //ArrayList abc = arrPerson.GetRange(1, 2);
            //foreach (Person item in abc)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            arrPerson.Sort(new SortPerson());
            foreach (Person item in arrPerson)
            {
                Console.WriteLine(item.ToString());
            }
            arrPerson.Reverse();
            foreach (Person item in arrPerson)
            {
                Console.WriteLine(item.ToString());
            }





        }

    }
    class SortPerson: IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;
            if (p1 == null|| p2 ==null)
            {
                throw new InvalidOperationException();
            }else
            {
                if(p1.Age<p2.Age)
                {
                    return -1;
                }
                if (p1.Age == p2.Age)
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
