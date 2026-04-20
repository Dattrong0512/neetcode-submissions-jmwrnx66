public class Solution {
    public void ReorderList(ListNode head) 
    {
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        fast = slow.next;
        slow.next = null;
        
        ListNode reverseNodeLater = null;
        while(fast != null)
        {
            ListNode temp = fast.next;
            fast.next = reverseNodeLater;
            reverseNodeLater = fast;
            fast = temp;
        }

        while(head != null && reverseNodeLater != null)
        {
            ListNode tempHead = head.next;
            ListNode tempReverseNode = reverseNodeLater.next;

            head.next = reverseNodeLater;
            reverseNodeLater.next = tempHead;
            head = tempHead;
            reverseNodeLater = tempReverseNode;
        }
    }
}
