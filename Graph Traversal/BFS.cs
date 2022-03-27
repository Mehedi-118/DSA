using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Traversal
{
    class Parent_Graph
    {
        int number_of_vertices;
        LinkedList<Int32>[] adj;
        public Parent_Graph(int number)
        {
            this.number_of_vertices = number;
            adj = new LinkedList<Int32>[number_of_vertices];
            for (int i = 0; i < number_of_vertices; i++)
                adj[i] = new LinkedList<Int32>();
        }
        public void addEdge(int from, int to)
        {
            adj[from].AddLast(to);
            adj[to].AddLast(from); //// if Undirectional graph
        }
        public void Print_Graph()
        {
            for (int i = 0; i < adj.Length; i++)
            {
                Console.Write(i + "-->");
                foreach (int p in adj[i])
                    Console.Write(p + " ");
                Console.WriteLine();
            }
        }
        public void BFS(int source, int destination)
        {
            int[] parent = new int[number_of_vertices];
            bool[] visited = new bool[number_of_vertices];
            visited[source] = true;
            parent[source] = -1;
            Queue<int> st = new Queue<int>();
            st.Enqueue(source);
            while (st.Count() != 0)
            {
                int node = st.Dequeue();
                if (node == destination)
                    break;
                else
                {
                    foreach (int neighbour in adj[node])
                    {
                        if (!visited[neighbour])
                        {
                            visited[neighbour] = true;
                            parent[neighbour] = node;
                            st.Enqueue(neighbour);
                        }
                    }

                }
            }
            print_path(parent,destination);
        }

        private void print_path(int[] parent,int destination)
        {
            int current = destination;
            while(parent[current]!=-1)
            {
                Console.WriteLine("Parent of {0} is {1}", current, parent[current]);
                current = parent[current];
            }
            Console.WriteLine("Source is {0}", current);
        }
    }
}
