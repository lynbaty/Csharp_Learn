using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan2
{
    public class XE
    {
        /*Một điểm dịch vụ cần quản lý các thông tin cho thuê xe đạp và xe máy. Với xe
        đạp cần lưu họ tên người thuê, số giờ thuê. Tiền thuê xe đạp được tính như sau:
        10000 (đồng) cho giờ đầu tiên, 80000 cho mỗi giờ tiếp theo. Với mỗi xe máy cần
        lưu họ tên người thuê, số giờ thuê, loại xe (100 phân khối, 250 phân khối), biển số.
        Tiền thuê xe máy được tính như sau: Đối với giờ đầu tiên, loại xe 100 phân khối
        tính 15000; loại xe 250 phân khối tính 20000. Đối với những giờ tiếp theo tính
        10000 cho cả hai loại xe máy.
        Viết chương trình xây dựng các lớp cần thiết sau đó nhập danh sách các thông tin
        thuê xe đạp và xe máy, sau đó xuất ra các thông tin sau:
        • Xuất tất cả các thông tin thuê xe (cả số tiền thuê tương ứng).
        • Tính tổng số tiền cho thuê xe đạp và xe máy.
        • Xuất tất cả các thông tin liên quan đến việc thuê xe đạp.
        • Tính tổng số tiền cho thuê xe máy loại 250 phân khối. 
         */

        protected string hoten;
        protected int giothue;
        public virtual int TienThue { get { return 0; } }
        public virtual void Xuat()
        {

        }
        public virtual string ID()
        {
            return "X";
        }


    }
    public class XEDAP:XE
    {
        XEDAP[] ListXD;
        public XEDAP()
        {

        }
        public int Songuoithue { get; set; }
        public XEDAP(string hoten, int gt)
        {
            this.hoten = hoten;
            this.giothue = gt;
        }
        public override string ID()
        {
            return "XD";
        }
        public override int TienThue
        {
            get
            {


                int t;
                t = (this.giothue - 1) * 8000 + 10000;
                return t;
            }

        }
        public override void Xuat()
        {
            Console.WriteLine($"{this.hoten} thue {this.ID()} {this.giothue} voi so tien {this.TienThue}");
        }
        public XEDAP this[int index]
        {
            get
            {
                if (index < 0 || index > this.Songuoithue)
                {
                    return null;
                }else
                {
                    return this.ListXD[index];
                }
            }
            set
            {
                if (!(index < 0 || index > this.Songuoithue))
                {
                    ListXD[index] = value;
                }
            }
        }

    }
    public class XEMAY: XE
    {
        string loaixe;
        string bienso;
        public XEMAY(string ht, int gt, string lx, string bs)
        {
            this.hoten = ht;
            this.giothue = gt;
            this.loaixe = lx;
            this.bienso = bs;
        }
        public override string ID()
        {
            if (this.loaixe == "100")
            {
                return "XM100";
            }
            else;
            {
                return "XM250";
            }
        }

        public override int TienThue
        {
            get
            {
                if(this.loaixe == "100")
                {
                    return (10000 * (this.giothue - 1) + 15000);
                }else
                {
                    return (10000 * (this.giothue - 1) + 20000);
                }
            }
        }

        public override void Xuat()
        {
            Console.WriteLine($"{this.hoten} thue {this.ID()} {this.giothue} voi so tien {this.TienThue}");
        }
    }
    //public class TEST
    //{
    //    static void Main()
    //    {

    //        XEDAP a = new XEDAP();
    //        XEMAY b;
    //        Console.WriteLine("So nguoi thue xe dap: ");
    //        a.Songuoithue = Convert.ToInt32( Console.ReadLine());
    //        XEDAP[] x = new XEDAP[a.Songuoithue];
    //        for (int i = 0; i < a.Songuoithue; i++)
    //        {
    //            Console.WriteLine($"Ho ten nguoi thue thu {i}: ");
    //            string ht = Console.ReadLine();
    //            Console.WriteLine($"So gio thue cua nguoi thue thu {i}: ");
    //            int gt = Convert.ToInt32(Console.ReadLine());

    //            x[i] = new XEDAP(ht, gt);

    //        }
    //        int TongXD = 0;
    //        for (int i = 0; i < a.Songuoithue; i++)
    //        {
    //            TongXD += x[i].TienThue;
    //        }
    //        Console.WriteLine($"tong tien thue xe dap la {TongXD}");

    //        for (int i = 0; i < a.Songuoithue; i++)
    //        {
    //            x[i].Xuat();
    //        }

    //    }
       
    //}
}
