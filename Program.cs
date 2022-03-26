using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
   
    internal class Program
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
                    //case 3:
                    //    Console.WriteLine("Enter Number of element: ");
                    //    val = Convert.ToInt32(Console.ReadLine());
                    //    MergeSort M_S = new MergeSort(val);
                    //    break;
                    //case 4:
                    //    Console.WriteLine("Enter Number of element: ");
                    //    val = Convert.ToInt32(Console.ReadLine());
                    //    QuickSort Q_S = new QuickSort(val);
                    //    break;
                    //case 5:
                    //    Console.WriteLine("Enter Number of element: ");
                    //    val = Convert.ToInt32(Console.ReadLine());
                    //    BubbleSort B_S = new BubbleSort(val);
                    //    break;
                    default:Environment.Exit(0);
                        break;


                }
            }
            

        }
           


        
    }
}
