using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class HocSinh
    {
        public string Hoten;
        float diemtoan;
        float diemvan;

        public HocSinh(string hoten, float diemtoan, float diemvan)
        {
            this.Hoten = hoten;
            this.diemtoan = diemtoan;
            this.diemvan = diemvan;
        }

        public void Thongtin()
        {
            Console.WriteLine($"Ho ten: {this.Hoten}");
            Console.WriteLine($"Diem toan: {this.diemtoan}");
            Console.WriteLine($"Diem van: {this.diemvan}");
        }
        public float Diemtrungbinh(HocSinh a)
        {
            return (a.diemtoan + a.diemvan) / 2;
        }

    }
}
