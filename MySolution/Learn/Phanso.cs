using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Phanso
    {
        public int Tu { get; set; }
        public int Mau { get; set; }

        public Phanso(int Tu, int Mau)
        {
            this.Tu = Tu;
            this.Mau = Mau;
        }
        public Phanso(int Tu)
        {
            this.Tu = Tu;
            this.Mau = 1;
        }
        public static bool operator== (Phanso a, Phanso b)
        {
            return (a.Tu * b.Mau == a.Mau * b.Tu);
        }
        public static bool operator!= (Phanso a, Phanso b)
        {
            return !(a == b);
        }
        public static Phanso operator+ (Phanso a, Phanso b)
        {
            int Tu = a.Tu * b.Mau + a.Mau * b.Tu;
            int Mau = a.Mau * b.Mau;
            Phanso x = new Phanso(Tu, Mau);
            return x;

        }
        public void Show()
        {
            Console.WriteLine($"Phan so: {this.Tu}/{this.Mau}");
        }
        public static Phanso operator++ (Phanso a)
        {
            int y = a.Tu + a.Mau;
            Phanso x = new Phanso(y, a.Mau);
            return x;
        }
        public static implicit operator bool(Phanso a)
        {
            return a.Mau != 0;
        }
        public static explicit operator int (Phanso a)
        {
            return a.Tu / a.Mau;
        }

       
    }
}