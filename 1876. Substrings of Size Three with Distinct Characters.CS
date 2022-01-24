A string is good if there are no repeated characters.

Given a string s​​​​​, return the number of good substrings of length three in s​​​​​​.

Note that if there are multiple occurrences of the same substring, every occurrence should be counted.

A substring is a contiguous sequence of characters in a string.

 

Example 1:

Input: s = "xyzzaz"
Output: 1
Explanation: There are 4 substrings of size 3: "xyz", "yzz", "zza", and "zaz". 
The only good substring of length 3 is "xyz".
Example 2:

Input: s = "aababcabc"
Output: 4
Explanation: There are 7 substrings of size 3: "aab", "aba", "bab", "abc", "bca", "cab", and "abc".
The good substrings are "abc", "bca", "cab", and "abc".
 

Constraints:

1 <= s.length <= 100
s​​​​​​ consists of lowercase English letters.

Success
Details 
Runtime: 81 ms, faster than 50.79% of C# online submissions for Substrings of Size Three with Distinct Characters.
Memory Usage: 35.2 MB, less than 56.35% of C# online submissions for Substrings of Size Three with Distinct



public class Solution {
    public int CountGoodSubstrings(string s) {
        
        int start = 0;
        int end = s.Length;
        
        
        
        for (int i =0; i< end-2; i++){
            var keys = new Dictionary <char, int>();
            bool check = true;
            for(int j =i; j< i+3; j++){
                
                if(keys.ContainsKey( s[j] )){ check = false; break; }
                else if(keys.ContainsKey(s[j]) == false ){keys[s[j]] =1; }
            }
            
            if(check == true){start ++;}
        }
        
        return start;
    }
}
