using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
    public class IntToRomanLeet
    {
        public string IntToRoman(int num) {
            var sb = new StringBuilder();
            Dictionary<int, string> lookup = new Dictionary<int, string>() {
                 { 1 ,"I"},
                 { 4 ,"IV"},
                 { 5 ,"V"},
                 { 9 ,"IX"},
                 { 10 ,"X"},
                 { 40 ,"XL"},
                 { 50 ,"L"},
                 { 90 ,"XC"},
                 { 100 ,"C"},
                 { 400 ,"CD"},
                 { 500 ,"D"},
                 { 900,"CM" },
                 { 1000 ,"M"},
                };
            while (num > 0) {
                int largestSoFar=0;
                foreach (var item in lookup)
                {
                    if (item.Key <= num) { largestSoFar = item.Key; }
                    else { break; }
                }
                num = num - largestSoFar;
                sb.Append(lookup[largestSoFar]);
            }
            return sb.ToString();
        }
    }
}
