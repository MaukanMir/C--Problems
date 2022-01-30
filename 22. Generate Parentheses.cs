Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

 

Example 1:

Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]
Example 2:

Input: n = 1
Output: ["()"]

Success
Details 
Runtime: 124 ms, faster than 77.29% of C# online submissions for Generate Parentheses.
Memory Usage: 45.2 MB, less than 6.08% of C# online submissions for Generate Parentheses.



public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        
        var seen = new List<string>();
        
        Backtrack("", 0,0,n,seen);
        return seen;
    }
    
    public static void Backtrack(string check, int l, int r, int n, List<string> seen){
        if(check.Length ==n*2){
            seen.Add(check);
        }
        if(l<r){return;}
        if(l<n){Backtrack(check + "(", l+1,r, n, seen);}
        if(l>r){Backtrack(check + ")", l,r+1, n, seen);}
    }
}
