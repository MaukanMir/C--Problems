A binary tree is uni-valued if every node in the tree has the same value.

Given the root of a binary tree, return true if the given tree is uni-valued, or false otherwise.

 

Example 1:


Input: root = [1,1,1,1,1,null,1]
Output: true
Example 2:


Input: root = [2,2,2,5,2]
Output: false
 

Constraints:

The number of nodes in the tree is in the range [1, 100].
0 <= Node.val < 100

Success
Details 
Runtime: 88 ms, faster than 92.57% of C# online submissions for Univalued Binary Tree.
Memory Usage: 39.4 MB, less than 12.16% of C# online submissions for Univalued Binary Tree.


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
    public bool IsUnivalTree(TreeNode root) {
        if (root == null){return true;}
    
    if (root.left != null){
        if (root.val != root.left.val){return false;}
    }
    
    if(root.right != null){
        if (root.val != root.right.val){return false;}
    }
    
    return IsUnivalTree(root.left) && IsUnivalTree(root.right);
    }
}
