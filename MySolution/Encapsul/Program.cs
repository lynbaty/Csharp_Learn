using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsul
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Nam = new Student("1223BC", "Nam", "nam@gmail.com", 20);

            //Nam.Id = "ABC12345873894578945794574894";
            //Console.WriteLine("Ma sinh vien " + Nam.Id);
            //Nam.Email = "boanku@gmail.com";
            //Console.WriteLine("Email: " + Nam.Email);
            //Console.WriteLine($"Tuoi goc {Nam.Age}");
            //Nam.Age++;
            //Console.WriteLine($"Tuoi moi {Nam.Age}");

            //Console.WriteLine(Nam.FirstName);
            //Employee e = new Employee();

            //Console.WriteLine(e.EmpId);
            //Instructor MyInstructor = new Instructor("INS1233123") {
            //    Name = "Tran van Hung",
            //    Age = 30,
            //    Slary = 50,
            //    Subject = new Subject("Van hoc"),

            //};
            //Console.WriteLine("Instrustor ID: " + MyInstructor.Id);
            //Console.WriteLine($"Name: {MyInstructor.Name}");
            //Console.WriteLine($"Age: {MyInstructor.Age}");
            //Console.WriteLine($"Slary: {MyInstructor.Slary}");
            //Console.WriteLine($"He teach {MyInstructor.Subject.Name}");
            
            Console.WriteLine(MyMath.PI);
            MyMath x = new MyMath();
            Console.WriteLine(x.Area(12));

            
        }
    }
}
