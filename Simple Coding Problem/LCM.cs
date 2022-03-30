using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Algorithm
{
    internal class LCM
    {
        public static int MIN(int a, int b)
        {
            return a < b ? a : b;

        }

        public static int LCMUtill(int a, int b, int k)
        {
            if (a == 1 || b == 1)
                return a * b;
            else if (a == b)
                return a;
            else if (k <= MIN(a, b))
            {
                if (a % k == 0 && b % k == 0)
                    return k * LCMUtill(a / k, b / k, 2);
                else
                    return LCMUtill(a, b, k + 1);
            }
            else
                return a * b;
        }


        public static void Driver_LCM(int a,int b)
        {
            int Lcm = LCMUtill(a, b, 2);
            Console.WriteLine("LCM of {0} and {1}:{2}\n",a,b,Lcm);
            
        }
    }
}
