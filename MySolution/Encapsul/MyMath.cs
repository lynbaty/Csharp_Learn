using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsul
{
    class MyMath
    {
        //truong du lieu la hang so = giu nguyen gia tri sau khi tao raư
        // hang so mac dinh public  tao ra dung ch ung trong class hoăc tat ca
        // perimeter
        // area
        public const float PI = 3.14f;

        public MyMath()
        {

        }
        public float Perimeter(float r)
        {
            return 2 * PI * r;
        }
        public float Area(float r)
        {
            return PI * r * r;
        }
    }
}
