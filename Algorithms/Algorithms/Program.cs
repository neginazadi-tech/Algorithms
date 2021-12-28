using Algorithms.Algorithms;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- Find Overlapping
            var intervals = new int[3][];
            intervals[0] = new int[2] { 1, 4 };
            intervals[1] = new int[2] { 0, 2 };
            intervals[2] = new int[2] { 3, 5 };
            var res = Overlapping.Merge(intervals);


            Console.ReadLine();
        }
    }
}
