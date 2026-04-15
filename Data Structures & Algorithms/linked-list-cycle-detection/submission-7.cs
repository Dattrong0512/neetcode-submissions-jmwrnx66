/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
    if (head == null || head.next == null)
    {
        return false;
    }
        ListNode slowSpeed = head;
        ListNode fastSpeed = head.next;
        while(slowSpeed != null && fastSpeed != null)
        {
            if(slowSpeed == fastSpeed)
            {
                return true;
            }
            slowSpeed = slowSpeed.next;
            if(fastSpeed.next == null)
            {
                return false;
            }
            else
            {
                fastSpeed = fastSpeed.next.next;
            }
        }
        return false;        
    }
}
