Given the root of a binary tree, construct a string consisting of parenthesis and integers from a binary tree with the preorder traversal way, and return it.

Omit all the empty parenthesis pairs that do not affect the one-to-one mapping relationship between the string and the original binary tree.

 

Example 1:


Input: root = [1,2,3,4]
Output: "1(2(4))(3)"
Explanation: Originally, it needs to be "1(2(4)())(3()())", but you need to omit all the unnecessary empty parenthesis pairs. And it will be "1(2(4))(3)"
Example 2:


Input: root = [1,2,3,null,4]
Output: "1(2()(4))(3)"
Explanation: Almost the same as the first example, except we cannot omit the first parenthesis pair to break the one-to-one mapping relationship between the input and the output.
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
-1000 <= Node.val <= 1000

Success
Details 
Runtime: 205 ms, faster than 18.07% of C# online submissions for Construct String from Binary Tree.
Memory Usage: 43.3 MB, less than 48.19% of C# online submissions for Construct String from Binary Tree.


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
    public string Tree2str(TreeNode root) {
        
        return Find(root);
        
    }
    
    public string Find( TreeNode root){
        if (root == null){
            return "";
        }
        string ans ="";
        ans = root.val.ToString();
        
        if(root.right != null){
            ans = ans + "(" + Find(root.left) + ")";
            ans = ans + "(" + Find(root.right) +")";
        }else if( root.left != null){
            ans = ans  + "(" + Find(root.left) +")";
        }
        return ans;
    }
}
