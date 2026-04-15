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
        while(fastSpeed != null && fastSpeed.next != null)
        {
            if(slowSpeed == fastSpeed)
            {
                return true;
            }
            slowSpeed = slowSpeed.next;
            fastSpeed = fastSpeed.next.next;
        }
        return false;        
    }
}
