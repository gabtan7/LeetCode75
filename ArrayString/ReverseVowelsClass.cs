using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class ReverseVowelsClass
    {
        public void Main()
        {
            string result = ReverseVowels("hello");
            Console.WriteLine(result);
        }

        public string ReverseVowels(string s)
        {
            List<Tuple<int, char>> vowelsList = new List<Tuple<int, char>>();
            List<Tuple<int, char>> vowelsListReversed = new List<Tuple<int, char>>();
            List<string> vowelRules = new List<string>();
            vowelRules.Add("a");
            vowelRules.Add("e");
            vowelRules.Add("i");
            vowelRules.Add("o");
            vowelRules.Add("u");

            for (int x = 0; x < s.Length; x++)
            {
                for (int y = 0; y < vowelRules.Count; y++)
                {
                    if (s[x].ToString().ToUpper() == vowelRules[y].ToString().ToUpper())
                    {
                        vowelsList.Add(new Tuple<int, char>(x, s[x]));
                    }
                }
            }

            StringBuilder sb = new StringBuilder(s);

            int z = vowelsList.Count - 1;
            for (int x = 0; x < vowelsList.Count; x++)
            {
                vowelsListReversed.Add(new Tuple<int, char>(vowelsList[z].Item1, vowelsList[x].Item2));
                z--;
            }

            for (int x = 0; x < vowelsListReversed.Count; x++)
            {
                sb[vowelsListReversed[x].Item1] = vowelsListReversed[x].Item2;
            }

            return sb.ToString();
        }
    }
}