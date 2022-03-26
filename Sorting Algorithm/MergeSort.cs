using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithm
{
    internal class MergeSort
    {
        int[] raw;
        int size;
        int[] sorted;
        
        public MergeSort(int size)
        {
            this.size = size;
            raw = new int[size];
            sorted = new int[size];
            var rand = new Random();
            Console.Write("Before Sorted:");
            for (int i = 0; i < size; i++)
            {
                raw[i] = rand.Next(10,21);
            }
            foreach (int i in raw)
                Console.Write(i+" ");
            Console.WriteLine();
            PrintSorted();

        }

        private void PrintSorted()
        {

            Console.Write("After  Sorted:");
            var sorted = Divide(raw);
            foreach(int i in sorted)
                Console.Write(i+" ");
            Console.WriteLine();
            return;
        }

        public int[] Divide(int [] raw)
        {
            if( raw.Length==1)
            { return raw; }
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for(int i=0;i<raw.Length;i++)
            { 
                if (i % 2 > 0)
                    left.Add(raw[i]);
                else
                    right.Add(raw[i]);
            }
            left = Divide(left.ToArray()).ToList();
            right = Divide(right.ToArray()).ToList();
            return Concure(left, right);
        }
        public int[]  Concure(List<int> left,List<int> right)
        {
            var result= new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())
                {

                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right.First());
                    right.RemoveAt(0);

                }
            }
            while (left.Count > 0)
            {
                result.Add(left.First());
                left.RemoveAt(0);
            } 
            while (right.Count > 0)
            {
                result.Add(right.First());
                right.RemoveAt(0);
            }

            return result.ToArray();
        }
    }
}
