using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Heap
{
    public class KthLargestElement
    {
        public int FindKthLargest(int[] nums, int k) {
            PriorityQueue<int, int> q = new();
            foreach (int i in nums)
            {
                q.Enqueue(i, i);
                if (q.Count>k) _=q.Dequeue();
            }
            return q.Peek();
        
        }
    }
}
