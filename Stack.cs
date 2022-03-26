using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Stack
    {
        int capacity, top;
        int[] arr;




        public Stack(int capacity)
        {

            this.capacity = capacity;
            arr = new int[capacity];
            this.top = -1;
            Console.WriteLine("Want to :\n1-->Push");
            Console.WriteLine("2-->Pop");
            Console.WriteLine("3-->Top");

            Console.WriteLine("4-->Exit");
            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        var item = Convert.ToInt32(Console.ReadLine());
                        Push(item);
                        break;
                    case 2:
                        Pop();
                        break;
                    case 3:
                        Top();
                        break;
                    case 4:
                        //Environment.Exit(0);
                        return;
                        //break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
        public void Push(int value)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stack is already full");
            }
            else
            {
                arr[++top] = value;
                Console.WriteLine("Value: " + value + " pushed Successfully");

            }

        }
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty, Nothing to pop");

            }
            else
                Console.WriteLine("Poped Successful : " + arr[top--]);
        }
        public void Top()
        {
            if (top == -1)
                Console.WriteLine("Stack is Empty");
            else
                Console.WriteLine("Top Element is : " + arr[top]);

        }
        public void Current()
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }


}
