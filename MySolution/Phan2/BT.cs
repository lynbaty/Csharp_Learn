using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Phan2
{
    class BT
    {
      static void Main ()
        {
            Regex reg = new Regex(@"\d");

            Match result = reg.Match("Bui Thien An 1203");
            while (result != Match.Empty)
            {
                Console.WriteLine(result.ToString());
                result = result.NextMatch();
            }
            foreach (var item in reg.Matches("Bui Thien An 098379327"))
            {
                Console.WriteLine(item.ToString());
            }




        }
       
    }
}
