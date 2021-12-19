You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.

Success
Details 
Runtime: 301 ms, faster than 25.50% of C# online submissions for Best Time to Buy and Sell Stock.
Memory Usage: 45.3 MB, less than 93.01% of C# online submissions for Best Time to Buy and Sell Stock.


public class Solution {
    public int MaxProfit(int[] prices) {
        
        int l =0;
        int r = 0;
        int maxProfit = 0;
        
        while(r<prices.Length){
            if(prices[r] > prices[l]){
                int profit = prices[r] - prices[l];
                maxProfit = Math.Max(profit, maxProfit);
            }else{
                l=r;
            }
            r+=1;
        }
        
        return maxProfit;
    }
}
