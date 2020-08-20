using System;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_11
    {
        public int[] Solution(int k, int[] array)
        {
            if (k > array.Length)
            {
                return null;
            }
            
            var result = new int[k];
            var rnd = new Random();
            
            for (var i = 0; i < k; i++)
            {
                result[i] = array[rnd.Next(i, array.Length)];
            }

            return result;
        }
    }
}