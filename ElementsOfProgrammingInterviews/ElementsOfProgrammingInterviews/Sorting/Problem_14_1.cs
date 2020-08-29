using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Sorting
{
    public class Problem_14_1
    {
        public List<int> Solution(int[] a, int[] b)
        {
            var result = new List<int>();
            
            var i = 0;
            var j = 0;

            while (i < a.Length && j < b.Length)
            {
                if (a[i] == b[j] && (i == 0 || a[i] != a[i - 1]))
                {
                    result.Add(a[i]);
                    i++;
                    j++;
                } 
                else if (a[i] < b[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return result;
        }
    }
}