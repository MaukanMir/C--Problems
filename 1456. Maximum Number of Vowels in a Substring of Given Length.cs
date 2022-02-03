Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

 

Example 1:

Input: s = "abciiidef", k = 3
Output: 3
Explanation: The substring "iii" contains 3 vowel letters.
Example 2:

Input: s = "aeiou", k = 2
Output: 2
Explanation: Any substring of length 2 contains 2 vowels.
Example 3:

Input: s = "leetcode", k = 3
Output: 2
Explanation: "lee", "eet" and "ode" contain 2 vowels.


Success
Details 
Runtime: 64 ms, faster than 97.06% of C# online submissions for Maximum Number of Vowels in a Substring of Given Length.
Memory Usage: 42.2 MB, less than 11.76% of C# online submissions for Maximum Number of Vowels in a given length


public class Solution {
    public int MaxVowels(string s, int k) {
        
        int count =0;
        string vowels= "aeiou";
        for(int i =0; i< k; i++){
            if (vowels.Contains(s[i]) ){count ++;}
        }
        
        int maxAmount = count;
        
        for( int i =0; i< s.Length-k; i++){
            if(vowels.Contains(s[i])){count--;}
            
            if(vowels.Contains(s[i+k])){
                count ++;
            }
            
            maxAmount = Math.Max(maxAmount, count);
        }
        
        return maxAmount;
        
    }
}
