using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms
{
   public static class MaxAreaAlgorithm
    {
        //Input: height = [1, 8, 6, 2, 5, 4, 8, 3]
        //                 0  1  2  3  4  5  6  7
        public static int MaxArea(int[] height)
        {
            int s = 0, i = 0, j = height.Length - 1;
            while (i < j)
            {
                s = Math.Max(s, (j - i) * Math.Min(height[i], height[j]));
                if (height[i] < height[j]) i++; else j--;
            }
            return s;
        }
    }
}
