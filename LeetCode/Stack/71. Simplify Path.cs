using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public class SimplifyPathLeet
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < path.Length; i++) {
                if (path[i] == '/') { 
                    continue;
                }
                int nextSlash = path.IndexOf('/',i);
                if (nextSlash != -1)
                {
                    switch (path[i..nextSlash])
                    {
                        case ".": break;
                        case "..":stack.Pop(); break;
                        default: stack.Push(path[i..nextSlash]); break;
                    }
                    i = nextSlash;
                }
                else 
                {
                    switch (path[i..])
                    {
                        case ".": break;
                        case "..": stack.Pop(); break;
                        default: stack.Push(path[i..]); break;
                    }

                    break;
                }

            }
            string result = string.Empty;
            while (stack.Count > 0)
            {
                result = $"{stack.Pop()}/{result}" ;
                
            }
            return "/"+ result[0..^1];
        }
    }
}
