using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LengthOfLastWordLeet
    {
        public int LengthOfLastWord(string s)
        {
            return s.Trim().Substring(s.Trim().LastIndexOf(" ") + 1).Length;
        }
    }
}
