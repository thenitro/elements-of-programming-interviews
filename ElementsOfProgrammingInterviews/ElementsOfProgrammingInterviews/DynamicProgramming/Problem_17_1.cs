namespace ElementsOfProgrammingInterviews.DynamicProgramming
{
    public class Problem_17_1
    {
        public int Solution(int[] coins, int n)
        {
            var dp = new int[coins.Length + 1, n + 1];

            for (var row = 0; row <= coins.Length; row++)
            {
                dp[row, 0] = 1;
            }

            for (var row = 1; row <= coins.Length; row++)
            {
                for (var col = 1; col <= n; col++)
                {
                    if (col < coins[row - 1])
                    {
                        dp[row, col] = dp[row - 1, col];
                    }
                    else
                    {
                        dp[row, col] = dp[row - 1, col] +
                                       dp[row, col - coins[row - 1]];
                    }
                }
            }

            return dp[coins.Length, n];
        }
    }
}