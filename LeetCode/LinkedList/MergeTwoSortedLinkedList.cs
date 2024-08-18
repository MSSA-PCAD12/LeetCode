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
            ListNode resultHead=new ListNode(-1);
            ListNode currentNode = resultHead;
            while (list1 != null && list2 != null)
            {

                if (list1.val <= list2.val)
                {
                    currentNode.next = list1;
                    list1 = list1.next!;

                }
                else
                {
                    currentNode.next = list2;
                    list2 = list2.next!;
                }
                currentNode = currentNode.next;


            }
            if (list1 == null)
            {
                currentNode.next = list2;
                return resultHead.next!;
            }
            else
            {
                currentNode.next = list1;
                return resultHead.next;
            }
            
        }
    }
}
