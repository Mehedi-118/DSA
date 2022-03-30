using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Algorithm
{
    internal class Factorial_With_Without_DP
    {
        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        public static int DP_Factorial(int n)
        {
            int[] arr = new int[n + 1];
            if (n <= 1)
                return n;
            if (arr[n] == 0)
            {
                arr[n] = n * DP_Factorial(n - 1);
            }

            return arr[n];

        }
    }
}
