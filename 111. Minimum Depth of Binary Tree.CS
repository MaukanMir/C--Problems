Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

Note: A leaf is a node with no children.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 2
Example 2:

Input: root = [2,null,3,null,4,null,5,null,6]
Output: 5
Success
Details 
Runtime: 436 ms, faster than 20.76% of C# online submissions for Minimum Depth of Binary Tree.
Memory Usage: 55.4 MB, less than 82.70% of C# online submissions for Minimum Depth of Binary Tree.

public class Solution {
    public int MinDepth(TreeNode root) {
        
        if(root == null){return 0;}
    if(root.right == null && root.left == null){return 1;}
    if(root.right == null){return 1 + MinDepth(root.left);}
    if(root.left == null){return 1+ MinDepth(root.right);}
    
    return Math.Min( MinDepth(root.right)+1, MinDepth(root.left)+1);
    }
}
