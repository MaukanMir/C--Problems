Given a binary array nums, return the maximum number of consecutive 1's in the array.

 

Example 1:

Input: nums = [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
Example 2:

Input: nums = [1,0,1,1,0,1]
Output: 2
 

Constraints:

1 <= nums.length <= 105
nums[i] is either 0 or 1.

Success
Details 
Runtime: 140 ms, faster than 55.25% of C# online submissions for Max Consecutive Ones.
Memory Usage: 41.7 MB, less than 8.16% of C# online submissions for Max Consecutive Ones.


public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        string[] got = string.Join("",nums).Split("0");
        return got.Select(x => x.Length  ).Max();
    }
}


Success
Details 
Runtime: 128 ms, faster than 94.64% of C# online submissions for Max Consecutive Ones.
Memory Usage: 41.4 MB, less than 18.66% of C# online submissions for Max Consecutive Ones.

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int max= 0;
        int curr =0;
        for(int i =0; i< nums.Length; i++){
            if(nums[i] ==1){
                curr +=1;
            }else if(nums[i] !=1 && curr>0){
                max = Math.Max(max,curr);
                curr =0;
            }
        } 
        
        return Math.Max(max,curr);
    }
}
