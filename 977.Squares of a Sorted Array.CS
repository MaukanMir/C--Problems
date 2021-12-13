Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

 

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in non-decreasing order.


Success
Details 
Runtime: 152 ms, faster than 81.29% of C# online submissions for Squares of a Sorted Array.
Memory Usage: 48.7 MB, less than 26.06% of C# online submissions for Squares of a Sorted Array.

public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        for(int i =0; i< nums.Length; i++){
            nums[i] = nums[i] * nums[i];
        }
        Array.Sort(nums);
        return nums;
    }
}


Success
Details 
Runtime: 164 ms, faster than 44.36% of C# online submissions for Squares of a Sorted Array.
Memory Usage: 48.7 MB, less than 26.06% of C# online submissions for Squares of a Sorted Array.

public class Solution {
    public int[] SortedSquares(int[] nums) {
        
       return nums.Select(x => x*x).OrderBy(x=>x).ToArray();
}
}
