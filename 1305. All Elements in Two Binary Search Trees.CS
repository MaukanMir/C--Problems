Given two binary search trees root1 and root2, return a list containing all the integers from both trees sorted in ascending order.

 

Example 1:


Input: root1 = [2,1,4], root2 = [1,0,3]
Output: [0,1,1,2,3,4]
Example 2:


Input: root1 = [1,null,8], root2 = [8,1]
Output: [1,1,8,8]

Success
Details 
Runtime: 356 ms, faster than 28.24% of C# online submissions for All Elements in Two Binary Search Trees.
Memory Usage: 47.1 MB, less than 100.00% of C# online submissions for All Elements in Two Binary Search Trees.


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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        
        List <int> values = new List <int>();
        
        Dfs(root1,values);
        Dfs(root2,values);
        
        return values.OrderBy(x=>x).ToArray();
        
    }
    
    public void Dfs(TreeNode node, List<int> values){
        if(node == null){
            return ;
        }
        
        if(node != null){
            values.Add(node.val);
        }
        
        if(node.left != null){
            Dfs(node.left,values);
        }
        if(node.right != null){
            Dfs(node.right,values);
        }
    }
}
