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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int currentValue = l1.val + l2.val;
        int tempValue = 0;
        if(currentValue / 10 > 0)
        {
            tempValue = currentValue / 10; 
            currentValue %= 10;
        }
        ListNode returnNode = new ListNode(currentValue);
        ListNode tempFirstNode = returnNode;
        l1 = l1.next;
        l2 = l2.next;
        int dumpValue = 0;
        while(l1 != null || l2 != null)
        {
            currentValue = (l1 != null ? l1.val : dumpValue) + (l2 != null ? l2.val : dumpValue) + tempValue;
            tempValue = 0;
            if(currentValue / 10 > 0)
            {
                tempValue = currentValue / 10; 
                currentValue %= 10;
            }
            ListNode newNode = new ListNode(currentValue);
            returnNode.next = newNode;
            returnNode = newNode;
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
        }

        if(tempValue != 0)
        {
            ListNode newNode = new ListNode(tempValue);
            returnNode.next = newNode;
        }

        returnNode = tempFirstNode;
        return returnNode;
    }
}