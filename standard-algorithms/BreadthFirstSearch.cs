// Read more about Breadtj-first Search: https://en.wikipedia.org/wiki/Breadth-first_search
// Class:                       Search algorithm
// Data structure:              Graph
// Worst-case performance:  O(|V| + |E|) = O(b ^ d)
// Worst-case space complexity: O(|V|) = O(b ^ d)

using System;
using System.Collections.Generic;
using System.Linq;

namespace standard_algorithms
{
    public class BFS
    {
        // Adjecency list.
        LinkedList<int>[] A;

        // Number of verteces.
        private int _V;

        // Graph with V number of verteces.
        public BFS(int V)
        {
            A = new LinkedList<int>[V];
            for (int i = 0; i < V; i++)
            {
                A[i] = new LinkedList<int>();
            }
            _V = V;
        }

        // Function to add edges to the graph.
        public void Add(int V1, int V2)
        {
            A[V1].AddLast(V2);
        }

        // Breadth-first Search traversal from a given source vertex S.
        public void BreadthFirstSearch(int S)
        {
            // Boolean array to track visited vertices.
            bool[] visited = new bool[_V];

            // Queue for Breadth-first search using a linked list.
            LinkedList<int> queue = new LinkedList<int>();

            // Mark source as visited.
            visited[S] = true;
            queue.AddLast(S);

            // Keep looping until queue is empty.
            while(queue.Count != 0)
            {
                // Dequeue a vertex.
                S = queue.First();
                Console.WriteLine($"{S} ");
                queue.RemoveFirst();

                // Get all adjecent vertices, enqueue all unvisited nodes and mark visited nodes as visited.
                LinkedList<int> L = A[S];
                foreach (var X in L)
                {
                    if (!visited[X])
                    {
                        visited[X] = true;
                        queue.AddLast(X);
                    }
                }
            }
        }
    }
}