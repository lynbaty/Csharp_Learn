using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsul
{
    class Student
    {
        private string id;
        private string firstName;
        //private string email;
        private int age;

        public Student()
        {


        }

        public Student(string id, string firstName, string email, int age)
        {
            Id = id;
            FirstName = firstName;
            Email = email;
            Age = age;

        }

        public string Email
        {
            get;
            set;
        }
        public int Age { get { return age; } set { age = value; } }
        public string Id
        {
            get { return id; }
            set
            {
                if (value.Length > 0 && value.Length <= 20)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Ma Sv ko hop le");
                }
            }
        }
        public string FirstName { get => firstName; set { firstName = value; } }
    }


    
}
