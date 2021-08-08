using System;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_7
    {
        public int Solution(int[] prices)
        {
            var maxTotalProfit = 0;
            var firstBuySellProfits = new int[prices.Length];
            var minPriceSoFar = int.MaxValue;

            for (var i = 0; i < prices.Length; i++)
            {
                minPriceSoFar = Math.Min(minPriceSoFar, prices[i]);
                maxTotalProfit = Math.Max(maxTotalProfit, prices[i] - minPriceSoFar);

                firstBuySellProfits[i] = maxTotalProfit;
            }

            var maxPriceSoFar = int.MinValue;
            for (var i = prices.Length - 1; i > 0; i--)
            {
                maxPriceSoFar = Math.Max(maxPriceSoFar, prices[i]);
                maxTotalProfit = Math.Max(maxTotalProfit, maxPriceSoFar - prices[i] + firstBuySellProfits[i - 1]);
            }


            return maxTotalProfit;
        }
    }
}