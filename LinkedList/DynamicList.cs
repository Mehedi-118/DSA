using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class DynamicList

    {
        static void Main(string[] args)
        {
            Linked_List list=new Linked_List();


            list.addNodeToEnd(10);
            list.addNodeToEnd(20);
            list.addNodeToEnd(40);
            list.addNodeToEnd(90);

            list.addNodeToFirst(50);
            list.addNodeToFirst(70);
            list.addNodeToFirst(1000);

            list.addNodeToPosition(990, 2);
            list.print();
            Console.Read();
        }
    }
}
