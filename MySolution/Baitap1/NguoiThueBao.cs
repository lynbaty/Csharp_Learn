using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    class NguoiThueBao
    {
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public NguoiThueBao(string Name, String Sdt)
        {
            this.Ten = Name;
            this.Sdt = Sdt;
        }
       
    }
    class DanhBa
    {
        public int size;
        public NguoiThueBao[] Number;

        public DanhBa()
        {

        }
        public DanhBa(int size)
        {
            this.size = size;
            this.Number = new NguoiThueBao[size];
        }
        public NguoiThueBao this[int index]
        {
            get
            {
                if (index < 0 || index >= this.size)
                {
                    return null;
                }
                else
                {
                    return this.Number[index];
                }
            }
            set
            {
                if (!(index < 0 || index >= this.size))
                {
                    this.Number[index] = value;
                }
            }
        }

        public void Nhapdanhba()
        {
            Console.WriteLine("Nhap so luong danh ba: ");
            this.size = Convert.ToInt32(Console.ReadLine());
            this.Number = new NguoiThueBao[this.size];
            for (int i = 0; i < this.size; i++)
            {
                Console.WriteLine($"Nhap Ho ten danh ba thu {i}");
                string a = Console.ReadLine();
                Console.WriteLine($"Nhap sdt danh ba thu {i}");
                string b = Console.ReadLine();
                this.Number[i] = new NguoiThueBao(a, b);
            }

        }
        public void Xuatdanhba()
        {
            Console.WriteLine("Xuat danh ba: ");
            for (int i = 0; i < this.size; i++)
            {
                Console.WriteLine($"Number {i}: ");
                Console.Write($"Ten: {this.Number[i].Ten} ");
                Console.Write($"Sdt: {this.Number[i].Sdt} ");
                Console.WriteLine();
            }
        }
        //tim sdt theo ten
        public void TimSdt(string x)
        {
            bool z = true;
            for (int i = 0; i < this.size; i++)
            {
                if (this.Number[i].Ten == x)
                {
                    Console.WriteLine($"sdt cua {x} la {this.Number[i].Sdt}");
                    z = false;
                }
            }
            if (z)
            {
                Console.WriteLine($"Khong co {x} trong danh ba he thong" );
            }
        }
        //tim ten theo sdt
        public void TimTen(string x)
        {
            bool z = true;
            for (int i = 0; i < this.size; i++)
            {
                if (this.Number[i].Sdt == x)
                {
                    Console.WriteLine($"Ten cua nguoi co sdt {x} la {this.Number[i].Ten}");
                    z = false;
                }
            }
            if (z)
            {
                Console.WriteLine($"khong co ai co sdt la {x}");
            }
        }
    }

}
