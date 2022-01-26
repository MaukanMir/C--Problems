Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.

 

Example 1:


Input: root = [3,1,4,null,2], k = 1
Output: 1
Example 2:


Input: root = [5,3,6,2,4,null,null,1], k = 3
Output: 3

Success
Details 
Runtime: 96 ms, faster than 78.88% of C# online submissions for Kth Smallest Element in a BST.
Memory Usage: 41.8 MB, less than 18.18% of C# online submissions for Kth Smallest Element in a BST.

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
    public int KthSmallest(TreeNode root, int k) {
        if(root == null){
            return 0;
        }
        
        var values = new List<int>();
        
        dfs(root,values);
        return values[k-1];
    }
    
    public void dfs(TreeNode node, List<int> values){
        if(node == null){
            return ;
        }
        
        dfs(node.left,values);
        values.Add(node.val);
        dfs(node.right, values);
    }
}
