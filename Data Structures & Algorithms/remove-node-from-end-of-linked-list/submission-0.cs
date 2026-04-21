public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        int lengthList = 0;
        ListNode current = head;
        while(current != null)
        {
            lengthList++;
            current = current.next;
        }
        int element = lengthList - n;
        if(element == 0)
        {
            return head.next;
        }     
        else
        {
            ListNode currentInstead = head;
            int i = 0;
            while(i < element - 1)
            {
                currentInstead = currentInstead.next;
                i++;
            }
            if(currentInstead.next != null)
            {
                currentInstead.next = currentInstead.next.next;
            }
        }

        return head;
    }
}