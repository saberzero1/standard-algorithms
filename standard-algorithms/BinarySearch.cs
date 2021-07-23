// Read more about Binary Search: https://en.wikipedia.org/wiki/Binary_search_algorithm
// Class:                       Search algorithm
// Data structure:              Array
// Worst-case performance:      O(log n)
// Best-case performance:       O(1)
// Average performance:         O(log n)
// Worst-case space complexity: O(1)

using System;

namespace standard_algorithms
{
    public class BinarySearch
    {
        // Expects a sorted integer array A and target to find T.
        // Returns the 0-based index of the target T or -1 if it is not found in the array.
        public static int BinarySearchFunc(int[] A, int T)
        {
            int L = 0;
            int R = A.Length - 1;
            while (L <= R)
            {
                int m = (int)Math.Floor((double)(L + R) / 2);
                if (A[m] < T)
                    L = m + 1;
                else if (A[m] > T)
                    R = m - 1;
                else return m;
            }
            return -1;
        }
    }
}