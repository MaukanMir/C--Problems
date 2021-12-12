iven the head of a singly linked list, return true if it is a palindrome.

 

Example 1:


Input: head = [1,2,2,1]
Output: true
Example 2:


Input: head = [1,2]
Output: false
 

Constraints:

The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 9


Success
Details 
Runtime: 304 ms, faster than 31.47% of C# online submissions for Palindrome Linked List.
Memory Usage: 58 MB, less than 5.05% of C# online submissions for Palindrome Linked List.
Next challenges:


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
    public bool IsPalindrome(ListNode head) {
        var seen = new List<int>();
        var curr = head;
        
        while(curr != null)
        { seen.Add(curr.val);
        curr = curr.next;
        }
        
        return string.Join("",seen.ToArray()) == string.Join("",seen.ToArray().Reverse());
        
    }
}
