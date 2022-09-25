using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace GraphFile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph graph = new Graph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);
            graph.PrintAdjacencyMatrix();
            Console.WriteLine("BFS traversal starting from vertex 1:");
            graph.BFS(1);
            Console.WriteLine("DFS traversal starting from vertex 1:");
            graph.DFS(1);
        }

        public class Graph
        {
            public void PrintAdjacencyMatrix()
            {
                for (int i = 0; i < Vertex; i++)
                {
                    Console.Write(i + ":[");
                    string s1 = "";
                    foreach (var k in adjacency[i])
                    {
                        s1 = s1 + (k + ",");

                    }
                    s1 = s1.Substring(0, s1.Length - 1);
                    s1 = s1 + "]";
                    Console.WriteLine(s1);
                    // Console.WriteLine();
                }
            }

            private int Vertex;
            private List<Int32>[] adjacency;
            public Graph(int v1)
            {
                Vertex = v1;
                adjacency = new List<Int32>[v1];
                for (int i = 0; i < v1; i++)
                {
                    adjacency[i] = new List<Int32>();
                }
            }
            public void AddEdge(int v1, int w1)
            {
                adjacency[v1].Add(w1);
            }
            public void BFS(int s1)
            {
                bool[] visited = new bool[Vertex];
                Queue<int> queue = new Queue<int>();
                visited[s1] = true;
                queue.Enqueue(s1);
                while (queue.Count != 0)
                {
                    s1 = queue.Dequeue();
                    Console.WriteLine("next->" + s1);
                    foreach (Int32 next in adjacency[s1])
                    {
                        if (!visited[next])
                        {
                            visited[next] = true;
                            queue.Enqueue(next);
                        }
                    }

                }
            }
            public void DFS(int s1)
            {
                bool[] visited = new bool[Vertex];
                Stack<int> stack = new Stack<int>();
                visited[s1] = true;
                stack.Push(s1);
                while (stack.Count != 0)
                {
                    s1 = stack.Pop();
                    Console.WriteLine("next->" + s1);
                    foreach (int i in adjacency[s1])
                    {
                        if (!visited[i])
                        {
                            visited[i] = true;
                            stack.Push(i);
                        }
                    }
                }

                
            }
        }

        // CLOSING BRACKETS
    }
}
