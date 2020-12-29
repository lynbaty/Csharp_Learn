using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class BT1
    {
        static void Main()
        {
            List<Phim> Phimchieurap = new List<Phim>
            {
                new Phim("001","Rung U Minh","TC",50000),
                new Phim("002","Diep Vien 2","HD",80000),
                new Phim("003","A Good Boy","SEX",100000),
                new Phim("004","Dieu Phu Nu Muon","HQ",85000),
                new Phim("005","Du Gau Popyy","HD",75000),
                new Phim("006","Tham Hoa Song Than","TC",60000),
                new Phim("007","Nhung nguoi cung kho","HQ",90000)
            };
            List<Phanloai> array = new List<Phanloai>
            {
                new Phanloai("TC","Phim Tinh Cam"),
                new Phanloai("HD","Phim Hanh Dong"),
                new Phanloai("SEX","Phim Con Heo"),
                new Phanloai("HQ","Phim Han Quoc")
            };
            //var query = from list in Phimchieurap
            //            where list.check("D") 
            //            orderby list.StartTL()
            //            select new { MATL = list.TheLoai, MAPHIM = list.TenPhim, GIA = list.DonGia };

            //var query = from list in Phimchieurap
            //            where list.DonGia >= 60000
            //            orderby list.StartTL() descending
            //            select new { MATL = list.TheLoai, MAPHIM = list.TenPhim, GIA = list.DonGia };

            var query = from list in Phimchieurap
                        join xx in array on list.TheLoai equals xx.MaTheLoai
                        group xx by new { list.MaPhim, list.TenPhim, xx.TenTheLoai, list.DonGia } into nh
                        select new { nh.Key.MaPhim, nh.Key.TenPhim, nh.Key.TenTheLoai, nh.Key.DonGia };

            foreach (var item in query)
            {
                Console.WriteLine($"{item.MaPhim} \t {item.TenPhim} \t {item.TenTheLoai} \t {item.DonGia}");
            }
        }
    }
    public class Phim
    {
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string TheLoai { get; set; }
        public int DonGia { get; set; }
        public Phim(string a, string b, string c, int d)
        {
            MaPhim = a;
            TenPhim = b;
            TheLoai = c;
            DonGia = d;
        }
        public string StartTL()
        {
            return TheLoai.Substring(0, 1);
        }
        public bool check(string a)
        {
            return TenPhim.StartsWith(a);
        }

    }
    public class Phanloai
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public Phanloai(string a, string b)
        {
            MaTheLoai = a;
            TenTheLoai = b;
        }
    }
}
