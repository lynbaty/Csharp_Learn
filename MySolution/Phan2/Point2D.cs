using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan2
{
    class Point2D
    {
        public int x, y;
        public void Xuat2D()
        {
            Console.WriteLine($"{this.x}, {this.y}");
        }

    }
    class Point3D: Point2D
    {
        public int z;
        public void Xuat3D()
        {
            Console.WriteLine($"{x},{y},{z}");
        }
    }
    

}
