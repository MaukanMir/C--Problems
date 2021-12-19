Given a string s, find the length of the longest substring without repeating characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.

Success
Details 
Runtime: 60 ms, faster than 99.62% of C# online submissions for Longest Substring Without Repeating Characters.
Memory Usage: 39.4 MB, less than 37.04% of C# online submissions for Longest Substring Without Repeating Characters.



public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int leftPointer =0;
        int result =0;
        
        var charSet = new HashSet<char>();
        
        for(int rightPointer =0; rightPointer<s.Length;rightPointer++){
            while( charSet.Contains(s[rightPointer])){
                charSet.Remove(s[leftPointer]);
                leftPointer +=1;
            }
            charSet.Add(s[rightPointer]);
            result = Math.Max(result,rightPointer -leftPointer +1);
        }
        
        return result;
    }
}
