using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhBa x = new DanhBa();
            x.Nhapdanhba();
            x.Xuatdanhba();
            Console.WriteLine("Nhap ten de tim sdt: ");
            string tenn = Console.ReadLine();
            x.TimSdt(tenn);
            Console.WriteLine("Nhap sdt de tim ten: ");
            string sdtt = Console.ReadLine();
            x.TimTen(sdtt);
        }
    }
}
