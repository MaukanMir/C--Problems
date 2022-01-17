Given the root of a binary tree, return the sum of all left leaves.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 24
Explanation: There are two left leaves in the binary tree, with values 9 and 15 respectively.
Example 2:

Input: root = [1]
Output: 0
 

Constraints:

The number of nodes in the tree is in the range [1, 1000].
-1000 <= Node.val <= 1000

Success
Details 
Runtime: 148 ms, faster than 11.31% of C# online submissions for Sum of Left Leaves.
Memory Usage: 36 MB, less than 99.65% of C# online submissions for Sum of Left Leaves.



/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        
        return Process(root, false);
    }
    
    public int Process(TreeNode root, bool is_left){
        if (root.left == null && root.right == null){
            return is_left == true ? root.val : 0;
        }
        
        int total =0;
        
        if( root.left != null){
            total += Process(root.left,true);
        }
        
        if(root.right != null){
            return total += Process(root.right, false);
        }
        
        return total;
    }
}
