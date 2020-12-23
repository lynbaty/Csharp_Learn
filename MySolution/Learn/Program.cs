using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            //HCN a = new HCN(1, 1, 8, 9);
            //Console.WriteLine(a.Chieudai());
            //Console.WriteLine(a.Chieurong());
            //Console.WriteLine(a.Chuvi());
            //Console.WriteLine(a.Dientich());
            //a.VeHCN();

            //Phanso a = new Phanso();
            //a.NhapPhanSo();
            //a.XuatPhanSo();
            //Phanso b = new Phanso();
            //b.NhapPhanSo();
            //b.XuatPhanSo();
            //Phanso c = new Phanso();
            //Phanso ketqua = c.Congphanso(a,b);
            //ketqua.XuatPhanSo();
            //Phanso d = new Phanso();
            //Phanso Rutgon = d.RutGon(a);
            //Rutgon.XuatPhanSo();

            //System.DateTime currentTime = System.DateTime.Now;
            //Time t = new Time(currentTime);
            //t.DisplayCurrentTime();
            //Time a = new Time(t);
            //a.DisplayCurrentTime();

            //Date a = new Date();
            //a.Show();
            //Date b = new Date(a);
            //b.Show();
            //System.DateTime x = System.DateTime.Now;
            //Date c = new Date(x);
            //c.Show();
            //Date d = new Date(14, 12, 2020);
            //d.Show();

            //LopHoc a = new LopHoc();
            //LopHoc a0 = a;
            //LopHoc a1 = a;
            //LopHoc a2 = a;
            //LopHoc a3 = a;
            //LopHoc a4 = a;
            //a.Khaibao(0,out a0);
            //a.Khaibao(1,out a1);
            //a.Khaibao(2,out a2);
            //a.Khaibao(3,out a3);
            //a.Khaibao(4,out a4);
            //a0.Show();
            //a1.Show();
            //a2.Show();
            //a3.Show();
            //a4.Show();

            //TamGiac x = new TamGiac(3, 3, 5);
            //Console.WriteLine(x.Chuvi);
            //Console.WriteLine(x.Dientich);
            //Console.WriteLine($"tam giac x la tam giac {x.Kiemtra()}");

            //Console.WriteLine(x.Canhd);

            //Phanso a = new Phanso(2, 6);
            //Phanso b = new Phanso(4, 0);
            //Console.WriteLine(a==b);
            //Phanso x = a + b;
            //x.Show();
            //b.Show();
            //b++;
            //b.Show();
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(a);

            Array x = new Array(4);
            x[3] = 5;
            x[1] = 4;
           
            for (int i = 0; i < x.Size ; i++)
            {
                Console.WriteLine(x[i]);
            }
            foreach (var item in x.MyArray)
            {
                Console.WriteLine(item);
            }










        }
    }
}
