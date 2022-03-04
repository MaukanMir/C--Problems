Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4


Success
Details 
Runtime: 93 ms, faster than 77.09% of C# online submissions for Search Insert Position.
Memory Usage: 37.9 MB, less than 40.96% of C# online submissions for Search Insert Position.


public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int left =0;
        int right = nums.Length-1;
        
        while (left<= right){
            int mid = left + (right-left)/2;
            if(nums[mid] == target){return mid;}
            else if(nums[right] > target){right -=1;}
            else{left++;}
        }
        return left;
    }
}
