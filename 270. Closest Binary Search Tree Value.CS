Given the root of a binary search tree and a target value, return the value in the BST that is closest to the target.

 

Example 1:


Input: root = [4,2,5,1,3], target = 3.714286
Output: 4
Example 2:

Input: root = [1], target = 4.428571
Output: 1
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
0 <= Node.val <= 109
-109 <= target <= 109

Success
Details 
Runtime: 76 ms, faster than 100.00% of C# online submissions for Closest Binary Search Tree Value.
Memory Usage: 39.4 MB, less than 47.18% of C# online submissions for Closest Binary Search Tree Value.



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
    public int ClosestValue(TreeNode root, double target) {
        if(root == null){
            return 0;
        }
        
        int minValue =root.val;
        int key = root.val;
        
        var node = root;
        while(node != null){
          
            
                if(node.val == target){return node.val;}
        
                minValue = Math.Abs(target- node.val) < Math.Abs(target- minValue) ? node.val: minValue;
                node = (target< node.val) ? node.left: node.right;
            
        }
        
        return minValue;
        
        
        
        
    }
}
