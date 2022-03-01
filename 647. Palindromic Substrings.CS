Given a string s, return the number of palindromic substrings in it.

A string is a palindrome when it reads the same backward as forward.

A substring is a contiguous sequence of characters within the string.

 

Example 1:

Input: s = "abc"
Output: 3
Explanation: Three palindromic strings: "a", "b", "c".
Example 2:

Input: s = "aaa"
Output: 6
Explanation: Six palindromic strings: "a", "a", "a", "aa", "aa", "aaa".


Success
Details 
Runtime: 60 ms, faster than 96.52% of C# online submissions for Palindromic Substrings.
Memory Usage: 36.4 MB, less than 40.15% of C# online submissions for Palindromic Substrings.


public class Solution {
    public int CountSubstrings(string s) {
        
        int result =0;
        
        for(int i =0; i< s.Length; i++){
            result += FindPalis(s, i,i);
            result += FindPalis(s,i,i+1);
        }
        
        return result;
    }
    
    public int FindPalis(string str, int lo, int high){
        int result =0;
        
        while(lo>= 0 && high < str.Length){
            if(str[lo] != str[high]){break;}
            lo--;
            high++;
            result++;
        }
        
        return result;
    }
}
