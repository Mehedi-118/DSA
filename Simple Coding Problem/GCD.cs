using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Algorithm
{
    internal class GCD
    {
        public static int GCD_Calc(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GCD_Calc(b, a % b);
        }
    }
}
