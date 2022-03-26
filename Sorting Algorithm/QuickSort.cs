using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class QuickSort
    {
        int[] arr;
        int size;
        public QuickSort(int size)
        {
            this.size = size;
            this.arr = new int[size];// { 17, 17, 16, 14, 19, 19, 17, 16, 16, 15 };
            Random rand = new Random();
            Console.Write("Before Sorted: ");

            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(10, 30);
                Console.Write(arr[i] + " ");
            }
            int low = 0,high=arr.Length;
            Console.WriteLine();
            Sort(arr,low,high);
            Console.Write("After  Sorted: ");

            foreach (int k in arr)
                Console.Write(k + " ");
            Console.WriteLine();
        }
        private void Sort(int[] arr,int low,int high)
        {
            if (low < high)
            {
                int p = partition(arr, low, high);
                Sort(arr, low, p - 1);
                Sort(arr, p + 1, high);
            }
            else return;
        }

        private int partition(int[] arr,int low,int high)
        {
            int pivot = arr[low];
            int i=low+1,j=high-1;

            while (i < j)
            {
                while (arr[i] <= pivot && i<j)
                    i++;
                //Console.WriteLine("I: " + i);
                while (arr[j] > pivot && j>=0) 
                    j--;
                //Console.WriteLine("j: " + j);
                if (i < j)
                {

                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                    //i++;j--;
                    //Console.WriteLine("Swaping :" + arr[i] + "--" + arr[j]);

                    //Console.WriteLine("Swap : " + arr[j] + "--" + arr[i]);
                }


            }
            int temp = pivot;
            arr[low] = arr[j];
            arr[j] = temp;
            //Console.WriteLine("Swaping Pivot with :" + arr[low] + " to " + arr[j]);
            //Console.WriteLine("Array becomes:");
            //foreach (int k in arr)
            //    Console.Write(k + " ");
            //Console.WriteLine(" partition J:"+j);


            return j;
        }
    }
    
}
