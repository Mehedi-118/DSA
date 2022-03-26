using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
   
    internal class Stack_Queue
    {
        static void Main(string[] args)
        {

            while (true) 
            { 
                Console.Write("---:::::::::::Enter option:::::::::::--- \n1--> Stack \n2-->Queue \n");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter Stack Size: ");

                        var val = Convert.ToInt32(Console.ReadLine());
                        Stack st = new Stack(val);
                        break;
                    case 2:
                        Console.WriteLine("Enter Queue Size: ");

                        val = Convert.ToInt32(Console.ReadLine());
                        Queue qu = new Queue(val);
                        break;
                    
                    default:Environment.Exit(0);
                        break;


                }
            }
            

        }
           


        
    }
}
