using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class MoveZeroesClass
    {
        public void Main()
        {
            MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
        }

        public void MoveZeroes(int[] nums)
        {
            List<int> nonZero = new List<int>();
            for (int x = 0; x < nums.Length; x++)
            {
                if (nums[x] != 0)
                {
                    nonZero.Add(nums[x]);
                }
            }

            for (int x = 0; x < nums.Length; x++)
            {
                if (x < nonZero.Count)
                {
                    nums[x] = nonZero[x];
                }
                else
                {
                    nums[x] = 0;
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}