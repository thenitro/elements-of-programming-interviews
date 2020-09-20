using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Recursion
{
    public class Problem_16_2
    {
        public List<List<int>> Solution(int n)
        {
            var result = new List<List<int>>();

            SolutionHelper(n, 0, new List<int>(), result);

            return result;
        }

        private void SolutionHelper(int n, int row, List<int> colPlacement, List<List<int>> result)
        {
            if (row == n)
            {
                result.Add(new List<int>(colPlacement));
                return;
            }

            for (var col = 0; col < n; col++)
            {
                colPlacement.Add(col);

                if (IsValid(colPlacement))
                {
                    SolutionHelper(n, row + 1, colPlacement, result);
                }
                
                colPlacement.RemoveAt(colPlacement.Count - 1);
            }
        }

        private bool IsValid(List<int> colPlacement)
        {
            var rowId = colPlacement.Count - 1;

            for (var i = 0; i < rowId; i++)
            {
                var diff = Math.Abs(colPlacement[i] - colPlacement[rowId]);
                if (diff == 0 || diff == rowId - i)
                {
                    return false;
                }
            }

            return true;
        }
    }
}