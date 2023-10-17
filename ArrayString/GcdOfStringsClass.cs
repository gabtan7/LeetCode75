using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class GcdOfStringsClass
    {
        public void Main()
        {
            string result = GcdOfStrings("ABCABC", "ABC");
            Console.WriteLine(result);
        }

        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 == str2 + str1)
            {
                int big = 0;
                int small = 0;
                if (str1.Length > str2.Length)
                {
                    big = str1.Length;
                    small = str2.Length;
                }
                else
                {
                    big = str2.Length;
                    small = str1.Length;
                }

                int remainder = -1;
                int smallDiv = small;
                int bigDiv = big;

                while (remainder != 0)
                {
                    remainder = bigDiv % smallDiv;
                    bigDiv = smallDiv;
                    smallDiv = remainder;
                }

                return (str2.Substring(0, bigDiv));
            }

            else
            {
                return "";
            }
        }
    }
}
