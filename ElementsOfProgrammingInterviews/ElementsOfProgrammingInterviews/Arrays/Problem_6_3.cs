using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_3
    {
        public List<int> Solution(int[] A, int[] B)
        {
            var sign = A[0] < 0 ^ B[0] < 0 ? -1 : 1;

            var n = A.Length;
            var m = B.Length;

            var r = n + m;

            var result = new int[r];

            for (var i = m - 1; i >= 0; i--)
            {
                for (var j = n - 1; j >= 0; j--)
                {
                    result[i + j + 1] += A[j] * B[i];
                    result[i + j] += result[i + j + 1] / 10;
                    result[i + j + 1] %= 10;
                }
            }
            
            var list = new List<int>();
            var prefix = true;

            for (var i = 0; i < result.Length; i++)
            {
                if (prefix && result[i] == 0)
                {
                    continue;
                }

                prefix = false;
                list.Add(result[i]);
            }

            list[0] *= sign;

            return list;
        }
    }
}