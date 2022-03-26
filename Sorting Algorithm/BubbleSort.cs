using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class BubbleSort
    {
        int len;
        int[] arr;
        bool swaped;
        public BubbleSort(int size)
        {
            this.len = size;
            arr = new int[size];
            swaped = false;
            Random rand = new Random();
            Console.Write("Before Sorted: ");
            for (int i = 0; i < len; i++)
                arr[i] = rand.Next(10, 30);
            foreach(int i in arr)
                Console.Write(i+" ");
            Console.WriteLine();
            Sort(arr);
            Console.Write("After  Sorted: ");
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        private void Sort(int[] arr)
        {
            for(int i =0;i< arr.Length;i++)
            {
                for(int j =0;j<arr.Length-i-1;j++)
                {
                    if(arr[j] >= arr[j+1])
                    {
                        int temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                        swaped=true;
                    }
                   
                }
                if(swaped==false)
                {
                    Console.WriteLine("Already Sorted");
                    break;
                }
                    
                //Console.WriteLine("After {0}th iteraton array:", i + 1);
                //foreach (int p in arr)
                //    Console.Write(p + " ");
                //Console.WriteLine();
            }

        }
    }
}
