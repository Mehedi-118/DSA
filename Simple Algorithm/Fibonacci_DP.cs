using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Algorithm
{
    internal class Fibonacci_DP
    {
        public static int DP_Fibbonacci(int n)
        {
            int[] arr = new int[n + 1];
            if (n <= 1)
                return n;
            if (arr[n] == 0)
            {
                arr[n] = DP_Fibbonacci(n - 1) + DP_Fibbonacci(n - 2);
            }

            return arr[n];

        }
    }
}
