using System;

namespace ElementsOfProgrammingInterviews.GreedyAlgorithmsAndInvariants
{
    public class Problem_18_7
    {
        public int Solution(int[] array)
        {
            var maxWater = int.MinValue;
            
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    var waterHeight = Math.Min(array[i], array[j]);
                    var waterWidth = j - i;

                    maxWater = Math.Max(maxWater, waterWidth * waterHeight);
                }
            }

            return maxWater;
        }
    }
}