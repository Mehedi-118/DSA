using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Algorithm
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int? choice =null;
            while (true)
            {
                Console.WriteLine("::::::::::Enter To Find::::::::::\n\n1-->{0}\n2-->{1}\n3-->{2}\n4-->{3}\n", "Factorial Using Dynamic programming", "Fibonacci Number Using Dynamic programming","Finding GCD of 2 numbers", "Finding LCM of 2 numbers");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Factorial of 5! ={0}\n",Factorial_With_Without_DP.DP_Factorial(5)); ///can Also take input from user;
                            break;

                        case 2:
                            Console.WriteLine("Fibonacci Number at 10th positon:{0}\n",Fibonacci_DP.DP_Fibbonacci(10));   ///can Also take input from user;
                            break;
                        case 3:
                            Console.WriteLine("GCD of 45 and 27 :{0}\n", GCD.GCD_Calc(45, 27));    ///can Also take input from user;
                            break;
                        case 4:LCM.Driver_LCM(10, 24);        ///can Also take input from user;
                            break;
                        default:
                            Environment.Exit(0);
                            break;

                    }
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}
