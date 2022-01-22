using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Algorithms
{
    public class LetterCombinationsSolution
    {
        /*
           Input: digits = "23"
           Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

            "234"
            ["adg","adh","adi","aeg","aeh","aei","afg","afh","afi","bdg","bdh","bdi","beg","beh","bei","bfg","bfh","bfi","cdg","cdh","cdi","ceg","ceh","cei",
            "cfg","cfh","cfi"]
 */
        public IList<string> LetterCombinations(string digits)
        {
            Queue<string> ans = new Queue<string>();
            if (digits.Length == 0) return ans.ToList();
            string[] mapping = new string[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            ans.Enqueue("");
            //234   abc  def=>     adg adh adi aeg   (avg of digit letter) ^ digitLen  9
            while(ans.Peek().Length != digits.Length)
            {
                var remove = ans.Dequeue();
                var map = mapping[digits[remove.Length] - '0'];
                foreach (var c in map)
                {
                    ans.Enqueue(remove + c);
                }
            }
            return ans.ToList();
        }
    }
}
