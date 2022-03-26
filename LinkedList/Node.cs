using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;  
            this.next = null;
        }
        
    }
    public class Linked_List
    {
        Node head;
        
        

        public void addNodeToEnd(int data)
        {
            if(this.head==null)
            {
               
                this.head = new Node(data);
                
            }
            else
            { 
                var curr = head;
                var newNode= new Node(data);
                while (curr.next!=null)
                    curr= curr.next;
                curr.next = newNode;
              

            }
            
            
        }
        public void addNodeToFirst(int data)
        {
            if (this.head == null)
            {
                this.head = new Node(data);
            }
            else
            {
                var newNode = new Node(data);
                newNode.next= this.head;
                head = newNode;
            }


        }
        public void addNodeToPosition(int data,int position)
        {
            var count = getCount(head);
            if (position <= count)
            {
                if (head != null)
                {
                    var newNode = new Node(data);
                    var prev = head;
                    for (int i = 0; i < position - 2; i++)
                        prev = prev.next;
                    newNode.next = prev.next;
                    prev.next = newNode;
                }
                else
                {
                    head = new Node(data);
                }
            }

            else

                Console.WriteLine("Wrong Position");
        }

        private int getCount(Node head)
        {
            var curr = head;
           
            int c=0;
            while (curr!= null)
            {
                curr = curr.next;
                ++c;
            }
            return c;
        }

        public void print()
        {
            var currentNode = head;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + "- ");
                currentNode = currentNode.next;
            }
            //Console.Read();
        }
    }
}
