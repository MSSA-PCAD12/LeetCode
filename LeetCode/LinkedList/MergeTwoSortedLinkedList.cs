using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/merge-two-sorted-lists/
    public class MergeTwoListsLeet
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode newHead = new ListNode(-1);
            ListNode node = new ListNode(-1);
            newHead = node;

            while (list1 != null && list2 != null)//there is still nodes left
            {
                if (list1.val < list2.val)
                {
                    node.next = list1;
                    list1 = list1.next!;
                }
                else
                {
                    node.next = list2;
                    list2 = list2.next!;
                }
                node = node.next;
            }
            if (list1 == null) { node.next = list2; }
            if (list2 == null) { node.next = list1; }
            return newHead.next!;
        }
    }
}
