using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsul
{
    class Instructor
    {
        public Instructor()
        {

        }
        public Instructor(string id )
        {
            Id = id;
            
        }
        public string Id { get; } = "ABC0001";
        public int Age { get; set; } = 20;
        public string Name { get; set; } = "Nam";
        public float Slary { get; set; } = 200000;
        public Subject Subject { get; set; } = new Subject();

    }
}
