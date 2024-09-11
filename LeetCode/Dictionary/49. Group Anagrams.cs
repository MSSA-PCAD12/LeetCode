using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Dictionary
{
    public class GroupAnagramLeet
    {
        public List<string>[] GroupAnagrams(string[] strs) {
            Dictionary<string, List<string>> result = new(comparer: new AnagramComparer<string>());

            for (int i = 0; i < strs.Length; i++) {
                if (result.ContainsKey(strs[i]))
                {
                    result[strs[i]].Add(strs[i]);
                }
                else
                {
                    result[strs[i]] = new List<string>() { strs[i] };
                }
                
            }
            return result.Select(p => p.Value).OrderBy(l=>l.Count).ToList().ToArray();
        }

        private class AnagramComparer<T> : IEqualityComparer<string>
        {
            public int GetHashCode([DisallowNull] string obj)
            {
                return new String(obj.OrderBy(c => c).ToArray()).GetHashCode();
            }
            bool IEqualityComparer<string>.Equals(string? x, string? y) => new String(x!.OrderBy(c=>c).ToArray())== new String(y!.OrderBy(c => c).ToArray());

        }
    }
}
   

