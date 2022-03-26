using System;

namespace Sorting_Algorithm
{
    internal class Sort
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("---:::::::::::Enter option:::::::::::--- \n1-->Merge Sort\n2-->Quick Sort\n3-->Bubble Sort\n");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        var val=-1;
                        Console.WriteLine("Enter Number of element: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        MergeSort M_S = new MergeSort(val);
                        break;
                    case 2:
                        Console.WriteLine("Enter Number of element: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        QuickSort Q_S = new QuickSort(val);
                        break;
                    case 3:
                        Console.WriteLine("Enter Number of element: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        BubbleSort B_S = new BubbleSort(val);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
