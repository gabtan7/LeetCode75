using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class ProductExceptSelfClass
    {
        public void Main()
        {
            var result = ProductExceptSelf(new int[]{1,2,3,4});
            Console.WriteLine(string.Join(", ", result));
        }

        public int[] ProductExceptSelf(int[] nums) {
		List<int> ans = new List<int>();
		List<int> before = new List<int>();
		int beforeProduct = 1;
		List<int> after = new List<int>();
		int afterProduct = 1;
		for (int x = 0; x < nums.Length; x++)
		{
			before.Add(1);
			after.Add(1);
		}

		int y = nums.Length - 1;
		for (int x = 0; x < nums.Length; x++)
		{
			after[x] *= afterProduct;
			afterProduct *= nums[x];

			before[y] *= beforeProduct;
			beforeProduct *= nums[y];
			y--;
		}
		
		for (int x = 0; x < nums.Length; x++)
		{
			ans.Add(after[x] * before[x]);
		}

		return ans.ToArray();
    }
    }
}