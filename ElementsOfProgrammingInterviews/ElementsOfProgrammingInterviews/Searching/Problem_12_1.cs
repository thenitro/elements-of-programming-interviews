using System;

namespace ElementsOfProgrammingInterviews.Searching
{
    public class Problem_12_1
    {
        public int Solution(int[] array, int t)
        {
            var l = 0;
            var r = array.Length - 1;
            var result = -1;

            while (l <= r)
            {
                var m = l + (r - l) / 2;
                
                if (t > array[m])
                {
                    l = m + 1;
                } 
                else if (t == array[m])
                {
                    result = m;
                    r = m - 1;
                }
                else
                {
                    r = m - 1;
                }
            }

            return result;
        }
    }
}