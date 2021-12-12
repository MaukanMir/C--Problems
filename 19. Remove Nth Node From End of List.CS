Given the head of a linked list, remove the nth node from the end of the list and return its head.

 

Example 1:


Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
 

Constraints:

The number of nodes in the list is sz.
1 <= sz <= 30
0 <= Node.val <= 100
1 <= n <= sz



Success
Details 
Runtime: 80 ms, faster than 88.28% of C# online submissions for Remove Nth Node From End of List.
Memory Usage: 38 MB, less than 30.43% of C# online submissions for Remove Nth Node From End of List.



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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int counter =0;
        ListNode fast =head;
        ListNode slow = head;
        
        while(counter <n){
            fast = fast.next;
            counter +=1;
        }
        
        if(fast == null){return head.next;}
        
        while(fast.next != null){
            fast = fast.next;
            slow = slow.next;
        }
        
        slow.next = slow.next.next;
        return head;
        
    }
}
