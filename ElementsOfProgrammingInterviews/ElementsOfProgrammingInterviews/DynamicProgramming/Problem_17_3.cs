namespace ElementsOfProgrammingInterviews.DynamicProgramming
{
    public class Problem_17_3
    {
        public int Solution(int n, int m)
        {
            var dp = new int[n, m];

            for (var i = 0; i < n; i++)
            {
                dp[i, 0] = 1;
            }

            for (var j = 0; j < m; j++)
            {
                dp[0, j] = 1;
            }

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[n - 1, m - 1];
        }
    }
}