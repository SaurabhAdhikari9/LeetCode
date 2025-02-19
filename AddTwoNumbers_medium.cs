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
    // added optional parameter carry to handle carry over value while adding node value.
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
    {
        if(l1 == null && l2 == null && carry == 0 ) return null; // return null if node value was null and no carry over
        l1 = l1 == null? new ListNode(): l1; // updating null node with default value null i.e. value = 0 and next = null
        l2 = l2 == null? new ListNode():l2;

        ListNode sum = new ListNode();
            int total = l1.val + l2.val +carry; 
             carry  = total / 10; // 10 / 10 =1; 1 need to carry over for next addition
             total = total % 10; // 10 % 10 = 0; 0 is the current total value that need to kept in node value.
            sum.val = total;
            sum = new ListNode(total, AddTwoNumbers(l1.next, l2.next, carry)); // recursive function 
        return sum; // return the node for the linkedlist.
    }
}