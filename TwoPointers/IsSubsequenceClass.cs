using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class IsSubsequenceClass
    {
        public void Main()
        {
            var result = IsSubsequence("abc", "ahbgdc");
            Console.WriteLine(result);
        }

        public bool IsSubsequence(string s, string t)
        {
            int currIndex = 0;

            for (int x = 0; x < t.Length; x++)
            {
                for (int y = currIndex; y < s.Length; y++)
                {
                    if (t[x] == s[y])
                    {
                        currIndex++;
                    }
                }
            }

            if (currIndex == s.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}