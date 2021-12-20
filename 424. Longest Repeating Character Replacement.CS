You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character. You can perform this operation at most k times.

Return the length of the longest substring containing the same letter you can get after performing the above operations.

 

Example 1:

Input: s = "ABAB", k = 2
Output: 4
Explanation: Replace the two 'A's with two 'B's or vice versa.
Example 2:

Input: s = "AABABBA", k = 1
Output: 4
Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
The substring "BBBB" has the longest repeating letters, which is 4.

Success
Details 
Runtime: 72 ms, faster than 82.47% of C# online submissions for Longest Repeating Character Replacement.
Memory Usage: 37.3 MB, less than 58.57% of C# online submissions for Longest Repeating Character Replacement.



public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int leftPointer =0;
        int maxCount = 0;
        int result =0;
        var count = new Dictionary <char,int>();
        
        for(int rightPointer =0; rightPointer <s.Length; rightPointer ++){
            
            if(count.ContainsKey(s[rightPointer])){ count[s[rightPointer]] +=1;}
            
            else{count[s[rightPointer]] =1;}
            
           maxCount = Math.Max(maxCount,count[s[rightPointer]]);
            
            while((rightPointer - leftPointer +1) - maxCount > k){
                
                count[s[leftPointer]] -=1;
                leftPointer +=1;
            }
            
            result = Math.Max(rightPointer - leftPointer +1,result);
            
        }
        
        return result;
    }
}
