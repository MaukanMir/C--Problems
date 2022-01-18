Given a non-empty special binary tree consisting of nodes with the non-negative value, where each node in this tree has exactly two or zero sub-node. If the node has two sub-nodes, then this node's value is the smaller value among its two sub-nodes. More formally, the property root.val = min(root.left.val, root.right.val) always holds.

Given such a binary tree, you need to output the second minimum value in the set made of all the nodes' value in the whole tree.

If no such second minimum value exists, output -1 instead.

 

 

Example 1:


Input: root = [2,2,5,null,null,5,7]
Output: 5
Explanation: The smallest value is 2, the second smallest value is 5.
Example 2:


Input: root = [2,2,2]
Output: -1
Explanation: The smallest value is 2, but there isn't any second smallest value.

Success
Details 
Runtime: 137 ms, faster than 21.10% of C# online submissions for Second Minimum Node In a Binary Tree.
Memory Usage: 36.4 MB, less than 60.55% of C# online submissions for Second Minimum Node In a Binary


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
    public int FindSecondMinimumValue(TreeNode root) {
        if(root == null){return -1;}
        
        List <int> result = new List<int>();
        
        Dfs(root,result);
        int[] result1 = result.OrderBy(x=> x).ToArray();
        
        for(int i =0; i< result1.Length; i ++){
            if(result1[i] > root.val){return result1[i];}
        }
        
        return -1;
    }
    
    public void Dfs(TreeNode node, List<int> result){
        if(node == null){return ;}
        
        result.Add(node.val);
        Dfs(node.left,result);
        Dfs(node.right,result);
            
    }
}
