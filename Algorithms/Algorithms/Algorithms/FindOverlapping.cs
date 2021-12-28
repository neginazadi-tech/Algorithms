using System;
using System.Collections.Generic;
using System.Linq;
namespace Algorithms.Algorithms
{
    /*Quesstion : Find overlapping
         Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
         Output: [[1,6],[8,10],[15,18]]
         Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].*/
    public static class Overlapping
    {
        //Time Complexity : o(n)  
        //Space Complexity : o(n)
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 1 || intervals == null) return intervals;
            intervals = intervals.OrderBy(x => x[0]).ToArray();
            var current = intervals[0];
            List<int[]> mergedIntervals = new List<int[]>() { };
            for (int i = 1; i < intervals.Length; i++)
            {
                if (current[1] >= intervals[i][0])
                {
                    current = new int[2] { current[0], Math.Max(current[1], intervals[i][1]) };
                }
                else
                {
                    mergedIntervals.Add(current);
                    current = intervals[i];
                }
            }
            mergedIntervals.Add(current);
            return mergedIntervals.ToArray();
        }
    }
}
