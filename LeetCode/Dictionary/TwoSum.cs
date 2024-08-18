using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/two-sum/
    public class TwoSumLeet
    {
        public int[] TwoSum(int[] input, int sum) {
            Dictionary<int,int> map = new Dictionary<int,int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (map.TryGetValue(sum - input[i], out int j)) { return [i, j]; }
                map[input[i]] = i; 
            }
            return [-1, -1];
        }
    }
}
