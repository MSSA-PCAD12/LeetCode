using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack
{
    public class MinStack
    {

        private Stack<(int, int)> _stack;
        public MinStack()
        {
            _stack = new();
        }

        public void Push(int val)
        {
            int min = int.MaxValue;
            if (_stack.TryPeek(out (int, int) item))
            {
                min = item.Item2;
            }
            _stack.Push((val, Math.Min(min, val)));
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public int Top()
        {
            return _stack.Peek().Item1;
        }

        public int GetMin()
        {
            return _stack.Peek().Item2;
        }
    }

}
