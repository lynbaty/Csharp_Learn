using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class TamGiac
    {
        float canha;
        float canhb;
        float canhc;

        public TamGiac(float a, float b, float c)
        {
            this.canha = a;
            this.canhb = b;
            this.canhc = c;
        }
        public int Canhd { get; set; } = 5;
        public float Chuvi { get { return (canha + canhb + canhc); } }
        public float Nuachuvi { get { return Chuvi / 2; }  }
        public Double Dientich { get { return Math.Sqrt(Nuachuvi * (Nuachuvi - canha) * (Nuachuvi - canhb) * (Nuachuvi - canhc)); } }

        public string Kiemtra()
        {
            if (canha == canhb && canhb == canhc)
            {
                return "tam giac deu";
            }
            else if (canha == canhb || canha == canhc || canhb == canhc)
            {
                if (canha == Math.Sqrt(canhb * canhb + canhc * canhc) || canhb == Math.Sqrt(canha * canha + canhc * canhc) || canhc == Math.Sqrt(canha * canha + canhb * canhb))
                {
                    return "Tam giac vuong can";
                } else
                {
                    return "tam giac can";
                }

            }
            else if (canha == Math.Sqrt(canhb*canhb + canhc*canhc) || canhb == Math.Sqrt(canha * canha + canhc * canhc) || canhc == Math.Sqrt(canha * canha + canhb * canhb))
            {
                return "tam giac vuong";

            } else
            {
                return "tam giac thuong";
            }    
            
        }
      


    }
}
