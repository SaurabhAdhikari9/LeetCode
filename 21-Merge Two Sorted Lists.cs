/**
Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

 

Example 1:


Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
 

Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order.
*/


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }'
 * }
 */

 // looping
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        ListNode result = new ListNode();
        ListNode temp = result;
        while(list1 != null && list2 != null){
            if(list1.val <= list2.val){
                temp.next = list1;
                list1 = list1.next;
                
            } else{
                temp.next = list2;
                list2 = list2.next;
            }             
            temp = temp.next;
        }        
        if(list1 == null) temp.next = list2;
        if(list2 == null) temp.next = list1;
        return result.next;
        
    }
}


// recursion 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        return MergeList(list1, list2);
    }
    private ListNode MergeList(ListNode node1, ListNode node2){
        if(node1 == null) return node2;
        if(node2 == null) return node1;
        
        if(node1.val <= node2.val){
            node1.next = MergeList(node1.next, node2);
            return node1;
                
        } else{
            node2.next = MergeList(node2.next, node1);
            return node2;
        }            
    }
}


// recursion 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
       if(list1 == null) return list2;
       if(list2 == null) return list1;
       if(list1.val <= list2.val){
        list1.next = MergeTwoLists(list1.next, list2);
        return list1;
       }
       else{
        list2.next = MergeTwoLists(list2.next, list1);
        return list2;
       }
    }
}
