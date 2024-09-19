using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Graph
{
    public class MinMutationLeet
    {
        public int MinMutation(string start, string end, string[] bank)
        {
            HashSet<string> hs = new(bank);
            Queue<(string, int)> queue = new();
            queue.Enqueue((start, 0));
            while (queue.Count > 0)
            {
                (string, int) curr = queue.Dequeue();
                if (curr.Item1 == end) return curr.Item2;
                char[] arr = curr.Item1.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    foreach (char ch in "ACGT")
                    {
                        char t = arr[i];
                        arr[i] = ch;
                        string next = new string(arr);
                        if (hs.Contains(next))
                        {
                            queue.Enqueue((next, curr.Item2 + 1));
                            hs.Remove(next);
                        }
                        arr[i] = t;
                    }
                }
            }
            return -1;
        }

        public int MinMutation2(string start, string end, string[] bank)
        {
          Queue<string> q = new Queue<string>();
            HashSet<string> seen = new();
          q.Enqueue(start);
            seen.Add(start);
            int resultLevel = 0;
            while (q.Count > 0)
            {
                int counter = q.Count;
                for (int i = 0; i < counter; i++)
                {
                    string node = q.Dequeue();
                    if (node == end) {return resultLevel;}
                    foreach (var nextWord in bank.Where(s => s.Diff(node) == 1))
                    { 
                        if (!seen.Contains(nextWord))
                            q.Enqueue(nextWord);
                    }
                    seen.Add(node);
                }
                resultLevel++;
            }

            return -1;            
        }
    }
     static class ExtClass
    {
        public static int Diff(this string s, string other)
        {
            int diff = 0;
            for (int i = 0; i < s.Length; i++) { 
                if (s[i] != other[i]) { diff++; }
            }
            return diff;
        }
    }
}
