

Given an array arr of integers, check if there exists two integers N and M such that N is the double of M ( i.e. N = 2 * M).

More formally check if there exists two indices i and j such that :

i != j
0 <= i, j < arr.length
arr[i] == 2 * arr[j]
 

Example 1:

Input: arr = [10,2,5,3]
Output: true
Explanation: N = 10 is the double of M = 5,that is, 10 = 2 * 5.
Example 2:

Input: arr = [7,1,14,11]
Output: true
Explanation: N = 14 is the double of M = 7,that is, 14 = 2 * 7.
Example 3:

Input: arr = [3,1,7,11]
Output: false
Explanation: In this case does not exist N and M, such that N = 2 * M.
 

Success
Details 
Runtime: 92 ms, faster than 90.24% of C# online submissions for Check If N and Its Double Exist.
Memory Usage: 40 MB, less than 53.80% of C# online submissions for Check If N and Its Double Exist.


public class Solution {
    public bool CheckIfExist(int[] arr) {
        
        for(int i =0; i< arr.Length; i++){
            int first = arr[i];
            int firstDoubled = first *2;
            
            int j = i+1;
            while(j< arr.Length){
                int second = arr[j];
                int secondDoubled = second *2;
                
                if(first == secondDoubled || second == firstDoubled){
                    return true;
                }
                j++;
            }
        }
        return false;
    }
}
