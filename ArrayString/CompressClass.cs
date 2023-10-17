using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class CompressClass
    {
        public void Main()
        {
            var result = Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
            Console.WriteLine(result);
        }

        public int Compress(char[] chars)
        {
            string result = String.Empty;
            string concat = "";
            int resultCount = 0;
            string currChar = "";
            foreach (char c in chars)
            {
                currChar = c.ToString();
                if (string.IsNullOrWhiteSpace(concat))
                {
                    concat += currChar;
                    resultCount++;
                }
                else
                {
                    if (currChar == concat.Substring(concat.Length - 1, 1))
                    {
                        resultCount++;
                    }
                    else
                    {
                        if (resultCount > 1)
                        {
                            concat += resultCount;
                        }

                        concat += currChar;
                        resultCount = 1;
                    }
                }
            }

            if (resultCount > 1)
            {
                concat += resultCount;
            }

            for (int x = 0; x < concat.Length; x++)
            {
                chars[x] = concat[x];
            }

            return concat.Length;
        }
    }
}