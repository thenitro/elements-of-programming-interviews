using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_19
    {
        public List<int[]> Solution(int N)
        {
            var result = new List<int[]>();
                result.Add(new int[] { 1 });
                result.Add(new int[] { 1, 1 });

            for (var i = 2; i < N; i++)
            {
                var subresult = new int[i + 1];
                    subresult[0] = 1;
                    subresult[i] = 1;
 
                for (var j = 1; j < i; j++)
                {
                    subresult[j] = result[i - 1][j - 1] + result[i - 1][j];
                }
                
                result.Add(subresult);
            }

            return result;
        }
    }
}