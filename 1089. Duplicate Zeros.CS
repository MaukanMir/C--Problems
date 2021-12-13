

Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

Note that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything.

 

Example 1:

Input: arr = [1,0,2,3,0,4,5,0]
Output: [1,0,0,2,3,0,0,4]
Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
Example 2:

Input: arr = [1,2,3]
Output: [1,2,3]
Explanation: After calling your function, the input array is modified to: [1,2,3]

Success
Details 
Runtime: 116 ms, faster than 97.82% of C# online submissions for Duplicate Zeros.
Memory Usage: 42.1 MB, less than 31.79% of C# online submissions for Duplicate Zeros.



public class Solution {
    public void DuplicateZeros(int[] arr) {
    
        int total = arr.Where(x=> x==0).ToArray().Length;
        int len = arr.Length;
        
        for(int i =len-1; i>=0; i--){
            if(i + total < len){
                arr[i + total] = arr[i];
            }
            if(arr[i] ==0){
                total -=1;
                if(i + total < len){
                    arr[i+total] =0;
                }
            }
        }
        return ;
    }
}
