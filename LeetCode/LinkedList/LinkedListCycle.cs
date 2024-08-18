using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/linked-list-cycle/
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;
            ListNode slowPointer = head, fastPointer = head.next;
            while (slowPointer != fastPointer)
            {
                if (fastPointer.next == null || fastPointer.next.next == null) return false;
                slowPointer = slowPointer.next!;
                fastPointer = fastPointer.next.next;
            }

            return true;
        }
    }

 public class ListNode(int x)
    {
      public int val = x;
      public ListNode? next = null;
    }
}
