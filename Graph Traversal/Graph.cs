using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Traversal
{
    internal class Graph
    {
        static void Main(string[] args)
        {
            int vertices, edges;
            vertices = Convert.ToInt32(Console.ReadLine());
            edges    = Convert.ToInt32(Console.ReadLine());
            Parent_Graph G = new Parent_Graph(vertices);
            //for (int i = 0; i < edges; i++)
            //{
            //    int from = Convert.ToInt32(Console.ReadLine());
            //    int to = Convert.ToInt32(Console.ReadLine());
            //    G.addEdge(from, to);
            //}
            G.addEdge(0, 4);
            G.addEdge(0, 3);
            G.addEdge(1, 2);
            G.addEdge(1, 4);
            G.addEdge(2, 3);
            G.addEdge(3, 4);

            G.Print_Graph();

            G.BFS(2,4);    // source =2 destination= 4
            Console.ReadLine();
        }
    }
}
