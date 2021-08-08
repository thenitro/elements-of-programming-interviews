using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_8
    {
        public List<int> Solution(int n)
        {
            var memo = new bool[n + 1];
            var result = new List<int>();

            for (var i = 2; i < n; i++)
            {
                if (memo[i] == false)
                {
                    result.Add(i);
                }
                
                for (var j = i; j < n; j += i)
                {
                    memo[j] = true;
                }
            }

            return result;
        }
    }
}