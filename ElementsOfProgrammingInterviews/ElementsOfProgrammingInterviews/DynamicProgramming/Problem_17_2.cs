using System;

namespace ElementsOfProgrammingInterviews.DynamicProgramming
{
    public class Problem_17_2
    {
        public int Solution(string A, string B)
        {
            var dp = new int[A.Length + 1, B.Length + 1];

            for (var i = 0; i < A.Length; i++)
            {
                dp[i, 0] = i;
            }

            for (var j = 0; j < B.Length; j++)
            {
                dp[0, j] = j;
            }

            for (var i = 1; i <= A.Length; i++)
            {
                for (var j = 1; j <= B.Length; j++)
                {
                    var substitutionCost = A[i - 1] == B[i - 1] ? 0 : 1;
                    var min = Math.Min(
                        dp[i - 1, j - 1] + substitutionCost,
                        Math.Min(
                            dp[i, j - 1] + 1,
                            dp[i - 1, j] + 1
                        ));

                    dp[i, j] = min;
                }
            }
            
            return dp[A.Length, B.Length];
        }
    }
}