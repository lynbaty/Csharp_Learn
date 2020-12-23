using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan2
{
    class HinhTron
    {
        public float BanKinh { get; set; }
        public float DuongKinh()
        {
            return this.BanKinh * 2;
        }
        public double Dientich()
        {
            return this.BanKinh * this.BanKinh * Math.PI;
        }



    }
    class HinhCau: HinhTron
    {
        public new double DienTich()
        {
            return 4 * Math.PI * this.BanKinh * this.BanKinh;
        }
        public double TheTich()
        {
            return this.BanKinh * Math.PI;
        }
    }
    class Test
    {
        static void Main()
        {
            HinhCau a = new HinhCau();
            a.BanKinh = 4;
            Console.WriteLine(a.DienTich());
            HinhTron b = a;
            Console.WriteLine(b.Dientich());
            Random r = new Random();
            int t;
            string s = "";
            Console.WriteLine(r);
            Console.WriteLine(r.Next());

           

        }
    }
}
