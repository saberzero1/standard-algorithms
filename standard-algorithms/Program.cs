using System;

namespace standard_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example driver code for Binary Search.
            Console.WriteLine("Binary Search Example:");
            int[] exampleBS = new int[10] { 1, 3, 4, 4, 5, 7, 9, 11, 14, 16 };
            int targetBS = 5;
            Console.WriteLine(BinarySearch.BinarySearchFunc(exampleBS, targetBS));

            // Example driver code for Breadth-first Search.
            Console.WriteLine("Breadth-first Search Example:");
            // For illustration, see this gif from Wikipedia: https://en.wikipedia.org/wiki/File:Animated_BFS.gif
            BFS exampleBFS = new BFS(8);
            exampleBFS.Add(0, 1);
            exampleBFS.Add(0, 2);
            exampleBFS.Add(1, 3);
            exampleBFS.Add(1, 4);
            exampleBFS.Add(2, 5);
            exampleBFS.Add(2, 6);
            exampleBFS.Add(4, 7);
            exampleBFS.BreadthFirstSearch(0);
            Console.ReadKey();
        }
    }
}
