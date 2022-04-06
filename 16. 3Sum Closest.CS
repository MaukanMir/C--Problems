Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

Return the sum of the three integers.

You may assume that each input would have exactly one solution.

 

Example 1:

Input: nums = [-1,2,1,-4], target = 1
Output: 2
Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
Example 2:

Input: nums = [0,0,0], target = 1
Output: 0

Success
Details 
Runtime: 118 ms, faster than 64.02% of C# online submissions for 3Sum Closest.
Memory Usage: 38.2 MB, less than 40.24% of C# online submissions for 3Sum Closest.


public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        
        int minValue = Int32.MaxValue;
        Array.Sort(nums);
        
        for(int i =0; i< nums.Length-2; i++){
            int left =i+1;
            int right = nums.Length-1;
            
            while(left < right){
                int total = nums[left] + nums[i] + nums[right];
                if(Math.Abs(target-total) < Math.Abs(minValue)){
                    minValue = target - total;
                }
                if(total < target){left++;}
                else{right --;}
            }
        }
        
        return target - minValue;
    }
}
