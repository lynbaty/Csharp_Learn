using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class HCN
    {
        public int x1, y1, x2, y2;
        public HCN()
        {

        }
        public HCN(int x1, int y1,int x2,int  y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public int Chieudai()
        {
            if(Math.Abs(x1 - x2) >= Math.Abs(y1 - y2))
            {
                return Math.Abs(x1 - x2);
            }else
            {
                return Math.Abs(y1 - y2);
            }    
        }
        public int Chieurong()
        {
            if (Math.Abs(x1 - x2) >= Math.Abs(y1 - y2))
            {
                return Math.Abs(y1 - y2);
            }
            else
            {
                return Math.Abs(x1 - x2);
            }
        }
        public int Chuvi()
        {
            return (Chieudai() + Chieurong()) * 2;
        }
        public int Dientich()
        {
            return Chieurong() * Chieudai();
        }
        public void VeHCN()
        {
            for (int i = 0; i < Math.Abs(y1 - y2); i++)
            {
                for (int j = 0; j < Math.Abs(x1 - x2); j++)
                {
                    if( i > 0 || i < (Math.Abs(y1 - y2) -1) )
                    {
                        if(j == 0 || j== (Math.Abs(x1 - x2) -1) )
                        {
                            Console.Write("*");

                        }else
                        {
                            Console.Write(" ");
                        }    


                    }else
                    {
                        Console.Write("*");
                    }    
                }
                Console.WriteLine();
            }
        }
    }
}
