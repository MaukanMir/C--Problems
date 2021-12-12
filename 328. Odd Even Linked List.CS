

Success
Details 
Runtime: 80 ms, faster than 90.30% of C# online submissions for Odd Even Linked List.
Memory Usage: 39.3 MB, less than 46.84% of C# online submissions for Odd Even Linked List.



Given the head of a singly linked list, group all the nodes with odd indices together followed by the nodes with even indices, and return the reordered list.

The first node is considered odd, and the second node is even, and so on.

Note that the relative order inside both the even and odd groups should remain as it was in the input.

You must solve the problem in O(1) extra space complexity and O(n) time complexity.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [1,3,5,2,4]
Example 2:


Input: head = [2,1,3,5,6,4,7]
Output: [2,3,6,7,1,5,4]
 

Constraints:

n == number of nodes in the linked list
0 <= n <= 104
-106 <= Node.val <= 106
Accepted
473,505
Submissions
802,502


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
    public ListNode OddEvenList(ListNode head) {
        if(head?.next ==null){return head;}
        var evenHead = head.next;
        var odd = head;
        var even = evenHead;
        
        while(true){
            odd.next = even.next;
            if(odd.next == null){
                odd.next = evenHead;
                return head;
            }
            odd = odd.next;
            even.next = odd.next;
            if(even.next == null){
                odd.next = evenHead;
                return head;
            }
            even = even.next;
        }
    }
}
