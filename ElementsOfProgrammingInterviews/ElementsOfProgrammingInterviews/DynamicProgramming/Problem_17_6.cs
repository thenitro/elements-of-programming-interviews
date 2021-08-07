using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.DynamicProgramming
{
    public class Problem_17_6
    {
        public int Solution(List<Tuple<int, int>> clocks, int maxWeight)
        {
            var dp = new int[clocks.Count + 1, maxWeight + 1];

            for (var i = 1; i <= clocks.Count; i++)
            {
                for (var j = 1; j <= maxWeight; j++)
                {
                    var currentClock = clocks[i - 1];
                    var clockPrice = currentClock.Item1;
                    var clockWeigh = currentClock.Item2;

                    dp[i, j] = j < clockWeigh
                        ? dp[i - 1, j]
                        : Math.Max(dp[i - 1, j], dp[i - 1, j - clockWeigh] + clockPrice);
                }
            }
            
            return dp[clocks.Count, maxWeight];
        }
    }
}