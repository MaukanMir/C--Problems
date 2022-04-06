Given an array of n integers nums and an integer target, find the number of index triplets i, j, k with 0 <= i < j < k < n that satisfy the condition nums[i] + nums[j] + nums[k] < target.

 

Example 1:

Input: nums = [-2,0,1,3], target = 2
Output: 2
Explanation: Because there are two triplets which sums are less than 2:
[-2,0,1]
[-2,0,3]
Example 2:

Input: nums = [], target = 0
Output: 0
Example 3:

Input: nums = [0], target = 0
Output: 0
 

Constraints:

n == nums.length
0 <= n <= 3500
-100 <= nums[i] <= 100
-100 <= target <= 100


Success
Details 
Runtime: 110 ms, faster than 80.58% of C# online submissions for 3Sum Smaller.
Memory Usage: 38.4 MB, less than 21.36% of C# online submissions for 3Sum Smaller.


public class Solution {
    public int ThreeSumSmaller(int[] nums, int target) {
        
        
        int result =0;
        int[] numss = nums.OrderBy(x=> x).ToArray();
        
        for(int i =0; i< numss.Length-2; i++){
            int left = i+1;
            int right = numss.Length-1;
            
            while(left < right){
                if( numss[left] + numss[right] + numss[i] < target){
                    result += right -left;
                    left++;
                }else{right -=1;}
            }
        }
        
        return result;
    }
}
