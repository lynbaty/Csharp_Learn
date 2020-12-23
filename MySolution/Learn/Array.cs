using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Array
    {
        //Public Kieutrave this[danh sach tham so] {get; set;}

        public int[] MyArray { get; set; }
        public int  Size { get; set; }


        public Array(int n)
        {
            this.Size = n;
            this.MyArray = new int[this.Size];

        }
        public int this [int index]
        {
            get
            {
                if (index <0 || index >=Size)
                {
                    return 0;
                }else
                {
                    return this.MyArray[index];

                }

            }
            set
            {
                if(!(index < 0 || index >= Size))
                {
                    this.MyArray[index] = value;
                }
            }
        }
    }
}
