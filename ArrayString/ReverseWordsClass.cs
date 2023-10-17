using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class ReverseWordsClass
    {
        public void Main()
        {
            string result = ReverseWords("the sky is blue");
            Console.WriteLine(result);
        }

        public string ReverseWords(string s)
        {
            List<string> stringList = new List<string>();
            string[] stringSplit = s.Split(' ');

            for (int x = 0; x < stringSplit.Length; x++)
            {
                if (stringSplit[x] != "")
                {
                    stringList.Add(stringSplit[x].ToString());
                }
            }

            string result = "";

            for (int x = stringList.Count - 1; x >= 0; x--)
            {
                result += stringList[x] + " ";
            }

            return result.Substring(0, result.Length - 1);
        }
    }
}