using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Algorithms
{
    public static class _3Sum
    {
        /*
         * Input: nums = [-1,2,1,-4], target = 1
            Output: 2
            Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
         * 
         */
        public static int ThreeSumClosest(int[] nums, int target)
        {
            int result = nums[0] + nums[1] + nums[nums.Length - 1];
            if (nums.Length < 2) return nums[0];
            nums = nums.OrderBy(x => x).ToArray();
            for (int i = 0; i < nums.Length-2; i++)
            {
                int j = i + 1;
                int end = nums.Length - 1;
                while (j < end)
                {
                    int sum = nums[i] + nums[j] + nums[end];
                    if (sum > target)
                    {
                        end--;
                    }
                    else
                    {
                        j++;
                    }
                    if (Math.Abs(sum - target) < Math.Abs(result - target))
                    {
                        result = sum;
                    }
                }
            }
           return result;
        }
        /*
         *Input: nums = [-1,0,1,2,-1,-4]
          Output: [[-1,-1,2],[-1,0,1]]

         */
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new HashSet<IList<int>>(new SequenceComparer<int>());
            if (nums.Length < 2) return result.ToList();
            nums = nums.OrderBy(x => x).ToArray();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int k = nums.Length - 1;
                int j = i + 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0) result.Add(new int[] { nums[i], nums[j++], nums[k--] });
                    else if (sum < 0) j++;
                    else if (sum > 0) k--;
                }
            }

            return result.ToList();
        }

    }
    class SequenceComparer<T> : IEqualityComparer<IEnumerable<T>>
    {
        public bool Equals(IEnumerable<T> seq1, IEnumerable<T> seq2)
        {
            return seq1.SequenceEqual(seq2);
        }

        public int GetHashCode(IEnumerable<T> seq)
        {
            int hash = 1234567;
            foreach (T elem in seq)
                hash = unchecked(hash * 37 + elem.GetHashCode());
            return hash;
        }
    }
}
