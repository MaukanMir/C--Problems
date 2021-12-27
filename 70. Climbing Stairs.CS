You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

 

Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step

Success
Details 
Runtime: 24 ms, faster than 96.99% of C# online submissions for Climbing Stairs.
Memory Usage: 26.9 MB, less than 20.93% of C# online submissions for Climbing Stairs.


public class Solution {
    public int ClimbStairs(int n) {
        int one =1;
        int two =1;
        int temp =0;
        for(int i =0; i<n-1; i++){
            temp =one;
            one = one + two;
            two = temp;
        }
        return one;
    }
}
