using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    class DuongTron
    {
        public float BanKinh { get; set; }
        static float Pi = 3.14f;

        public DuongTron(float BanKinh)
        {
            this.BanKinh = BanKinh;
        }
        public double Chuvi()
        {
            return this.BanKinh * 2 * DuongTron.Pi;
        }
        public double Dientich()
        {
            return this.BanKinh * this.BanKinh * DuongTron.Pi;
        }
    }
}
