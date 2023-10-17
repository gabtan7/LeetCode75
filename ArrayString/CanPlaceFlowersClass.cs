using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode75
{
    public class CanPlaceFlowersClass
    {
        public void Main()
        {
            var result = CanPlaceFlowers(new int[]{1,0,0,0,1}, 1);
            Console.WriteLine(result);
        }

        public bool CanPlaceFlowers(int[] flowerbed, int n) {
		int[] copy = new int[flowerbed.Length + 2];

        for(int x = 1; x < flowerbed.Length+1; x++){
            copy[x] = flowerbed[x-1];
        }
		
        for(int x = 1; x < copy.Length-1; x++){
            if(copy[x-1] == 0 && copy[x] == 0 & copy[x+1] == 0){
                copy[x] = 1;
                n--;
            }
        }
		
		if (n > 0){
			return false;
		}
		else
		{
			return true;
		}
    }
    }
}