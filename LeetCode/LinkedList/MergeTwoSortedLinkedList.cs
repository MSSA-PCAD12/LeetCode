using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/merge-two-sorted-lists/
    public class MergeTwoListsLeet
    {
       public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1==null) return list2;
        if (list2==null) return list1;

        ListNode newHead =new ListNode(-1);
        ListNode node= new ListNode(-1);
        newHead.next = node;
  
        while (list1.next!=null &&list2.next!=null)//there is still nodes left
        {
            if (list1.next==null){node = list1; node.next = list2; break;}
            if (list2.next==null){node = list2; node.next = list1; break;}
            if (list1.val < list2.val)
            {
                node = list1;
                list1 = list1.next;
            }else
            {
                node = list2;
                list2 = list2.next;
            }
           node=node.next;
        }
        return newHead.next;
    }
    }
}
