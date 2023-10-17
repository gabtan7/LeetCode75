using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class IncreasingTripletClass
    {
        public void Main()
        {
            var result = IncreasingTriplet(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(result);
        }

        public bool IncreasingTriplet(int[] nums)
        {
            int a = Int32.MaxValue;
            int b = Int32.MaxValue;
            if (nums.Length < 3)
            {
                return false;
            }
            else
            {
                for (int x = 0; x < nums.Length; x++)
                {
                    if (nums[x] <= a)
                    {
                        a = nums[x];
                    }
                    else if (nums[x] <= b)
                    {
                        b = nums[x];
                    }
                    else
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}