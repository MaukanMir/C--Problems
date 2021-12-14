Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1



Success
Details 
Runtime: 244 ms, faster than 13.35% of C# online submissions for Move Zeroes.
Memory Usage: 44.5 MB, less than 93.10% of C# online submissions for Move Zeroes.


public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int check =0;
        
        for( int i =0; i< nums.Length;  i++){
            if(nums[i] !=0){
                nums[check] = nums[i];
                check ++;
            }
        }
        for(int i = check; i < nums.Length; i++){
            nums[i] =0;
        }
        
        
    }
}
