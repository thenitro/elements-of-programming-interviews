using System;

namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_10
    {
        public int Solution(int lowerBound, int upperBound)
        {
            var random = new Random();
            var numberOfOutcomes = upperBound - lowerBound + 1;
            var result = 0;

            do
            {
                result = 0;

                for (var i = 0; (1 << i) < numberOfOutcomes; i++)
                {
                    result = (result << 1) | random.Next(0, 1);
                }
            } while (result >= numberOfOutcomes);

            return result + lowerBound;
        }
    }
}