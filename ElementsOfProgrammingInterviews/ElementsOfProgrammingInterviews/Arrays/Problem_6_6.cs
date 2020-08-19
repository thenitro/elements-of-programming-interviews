using System;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_6
    {
        public int Solution(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            
            var bestDiff = int.MinValue;
            var min = int.MaxValue;
            var max = int.MinValue;

            for (var i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    max = array[i];
                }

                max = Math.Max(max, array[i]);

                var diff = max - min;
                if (diff > bestDiff)
                {
                    bestDiff = diff;
                }
            }

            return bestDiff;
        }
    }
}