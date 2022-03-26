using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Queue
    {
        int front=0, rear = -1,capacity;
        int[] arr;
        public Queue(int size)
        {
            this.capacity = size;   
            this.arr=new int[size];
            Console.WriteLine("Want to :\n1-->Enqueue");
            Console.WriteLine("2-->Dequeue");
            Console.WriteLine("3-->Front");
            Console.WriteLine("4-->Exit");
            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        var item = Convert.ToInt32(Console.ReadLine());
                        Enqueue(item);
                        break;
                    case 2:
                        Dequeue();
                        break;
                    case 3:
                        Front();
                        break;
                    case 4:
                        //Environment.Exit(0);
                        //break;
                        return;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
        public void Enqueue(int value)
        {
            if (rear == capacity-1)
                Console.WriteLine("Queue is Full");
            else
            {
                arr[++rear] = value;
                Console.WriteLine("Value: " + arr[rear] + " Enqueued Successfully");
            }
        }
        public void Dequeue()
        {
            if (rear == -1)
                Console.WriteLine("Queue is Empty");
            else
            { 
                Console.WriteLine("Value: " + arr[front] + " Dequeued Successfully");
                reArrange();
                rear--;
            }
            Console.WriteLine();
        }
        public void reArrange()
        {
            Console.WriteLine("Rear is :" + rear);
            for(int i=0;i<rear;i++)
            {
                arr[i] = arr[i+1];
            }
            arr[rear] = 0;
            foreach (int i in arr)
                Console.Write(i + " ");
        }
        public void Front()
        {
            if(rear == -1)
                Console.WriteLine("Queue is Empty");
            else
                Console.WriteLine("Front Element is : "+arr[front]);

        }
    }
}
