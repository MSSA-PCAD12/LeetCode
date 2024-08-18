using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/happy-number/
    public class IsHappyLeet
    {
        public bool IsHappy(int n)
        {
            int result = 0;
            HashSet<int> history = new();
            string input = n.ToString();
            while (result != 1)
            {
                result = 0;
                foreach (char item in input)
                {
                    result += (int)Math.Pow(Convert.ToInt32(item.ToString()), 2);
                }
                input = result.ToString();
                if (history.TryGetValue(result, out _)) return false;
                else
                    history.Add(result);

            }
            return true;
        }
    }
}
