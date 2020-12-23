using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsul
{
    class Subject
    {
        public Subject()
        {

        }
        public Subject(string name)
        {
            Name = name;
        }
        public string Name { get; set; } = "Vietnamese";
    }
}
