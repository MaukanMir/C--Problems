Your friend is typing his name into a keyboard. Sometimes, when typing a character c, the key might get long pressed, and the character will be typed 1 or more times.

You examine the typed characters of the keyboard. Return True if it is possible that it was your friends name, with some characters (possibly none) being long pressed.

 

Example 1:

Input: name = "alex", typed = "aaleex"
Output: true
Explanation: 'a' and 'e' in 'alex' were long pressed.
Example 2:

Input: name = "saeed", typed = "ssaaedd"
Output: false
Explanation: 'e' must have been pressed twice, but it was not in the typed output.
 

Constraints:

1 <= name.length, typed.length <= 1000
name and typed consist of only lowercase English letters.

Success
Details 
Runtime: 90 ms, faster than 60.78% of C# online submissions for Long Pressed Name.
Memory Usage: 36.6 MB, less than 51.96% of C# online submissions for Long Pressed Name.


public class Solution {
    public bool IsLongPressedName(string name, string typed) {
        
        
        int leftN = 0;
        int leftT = 0;
        
        while (leftN < name.Length && leftT < typed.Length){
            if(name[leftN] == typed[leftT]){
                leftN++;
                leftT++;
            }else if(leftN >0 && name[leftN-1] == typed[leftT]){
                leftT++;
            }else{
                return false;
            }
        }
        
        while( leftT < typed.Length ){
            if(name[leftN-1] != typed[leftT]){return false;}
            else{
                leftT++;
            }
        }
        
        return leftN < name.Length ? false: true;
    }
}
