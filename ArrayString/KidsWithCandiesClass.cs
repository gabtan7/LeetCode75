using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class KidsWithCandiesClass
    {
        public void Main()
        {
            var result = KidsWithCandies(new int[]{2,3,5,1,3}, 3);
            Console.WriteLine(string.Join(", ", result));
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> results = new List<bool>();
        bool result = false;

        for(int x = 0; x < candies.Length; x++){
            result = false;
            for(int y = 0; y < candies.Length; y++){
                if(x != y){
                    if(candies[x] + extraCandies >= candies[y]){
                        result = true;
                    }
                    else{
                        result = false;
                        break;
                    }
                }
            }
            results.Add(result);
        }

        return results;
    }
    }
}