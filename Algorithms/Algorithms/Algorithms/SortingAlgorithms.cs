using System;
namespace Algorithms.Algorithms
{
    public static class SortingAlgorithms
    {
        // it is an  algorithm for sorted array
        //time complexity: o(logn) space = o(1)
        public static int BinarySearch(int[] arr, int key)
        {
            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    end = mid - 1;
                }
                else start = mid + 1;
            }

            return -1;
        }
    }
}
