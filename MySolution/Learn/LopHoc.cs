using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class LopHoc
    {
        public string name;
        public float diemvan;
        public float diemtoan;
        public float diemtb;

        public LopHoc()
        {

        }
        public LopHoc(string name, float diemvan, float diemtoan)
        {
            this.name = name;
            this.diemvan = diemvan;
            this.diemtoan = diemtoan;
            this.diemtb = (diemvan + diemtoan) / 2;
        }
        public void Khaibao(int n,out LopHoc x)
        {
            Console.WriteLine($"Ten hoc sinh thu {n}");
            string name = Console.ReadLine();
            Console.WriteLine($"Diem van hoc sinh thu {n}");
            float diemvan = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Ten hoc sinh thu {n}");
            float diemtoan = Convert.ToSingle(Console.ReadLine());
            x = new LopHoc(name, diemvan, diemtoan);

        }
        public void Show()
        {
            Console.WriteLine($"Ten: {this.name}");
            Console.WriteLine($"Diem van: {this.diemvan}");
            Console.WriteLine($"Diem Tb: {this.diemtoan}");
            Console.WriteLine($"Diem Tb: {this.diemtb}");
        }

    }
}
