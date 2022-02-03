Given a binary array data, return the minimum number of swaps required to group all 1’s present in the array together in any place in the array.

 

Example 1:

Input: data = [1,0,1,0,1]
Output: 1
Explanation: There are 3 ways to group all 1's together:
[1,1,1,0,0] using 1 swap.
[0,1,1,1,0] using 2 swaps.
[0,0,1,1,1] using 1 swap.
The minimum is 1.
Example 2:

Input: data = [0,0,0,1,0]
Output: 0
Explanation: Since there is only one 1 in the array, no swaps are needed.
Example 3:

Input: data = [1,0,1,0,1,0,0,1,1,0,1]
Output: 3
Explanation: One possible solution that uses 3 swaps is [0,0,0,0,0,1,1,1,1,1,1].

Success
Details 
Runtime: 306 ms, faster than 41.01% of C# online submissions for Minimum Swaps to Group All 1's Together.
Memory Usage: 46.4 MB, less than 5.04% of C# online submissions for Minimum Swaps to Group All 1's Together.


public class Solution {
    public int MinSwaps(int[] data) {
        
        int left =0;
        int right =0;
        int maxValue = -1;
        int ones = data.Select(x=>x).Sum();
        int count =0;
        
        while(right < data.Length){
            count += data[right];
            right++;
            
            if(right- left > ones){
                count -= data[left];
                    left ++;
            }
            
            maxValue = Math.Max(maxValue, count);
        }
        
        return ones - maxValue;
    }
}
