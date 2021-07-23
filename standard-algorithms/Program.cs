using System;

namespace standard_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] example = new int[10] { 1, 3, 4, 4, 5, 7, 9, 11, 14, 16 };
            int target = 5;
            Console.WriteLine(BinarySearch.BinarySearchFunc(example, target));
            Console.ReadKey();
        }
    }
}
