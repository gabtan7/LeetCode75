using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class MergeAlternatelyClass
    {
        public void Main()
        {
            string result = MergeAlternately("abc", "pqr");
            Console.WriteLine(result);
        }

        public string MergeAlternately(string word1, string word2)
        {
            string result = "";
            int max = Math.Max(word1.Length, word2.Length);

            for (int x = 0; x < max; x++)
            {
                if (x < word1.Length)
                {
                    result += word1[x];
                }
                if (x < word2.Length)
                {
                    result += word2[x];
                }
            }

            return result;
        }
    }
}