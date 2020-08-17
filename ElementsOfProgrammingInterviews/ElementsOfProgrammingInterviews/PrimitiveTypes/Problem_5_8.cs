using System;

namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_8
    {
        public int Solution(int x)
        {
            var result = 0;

            while (x > 0)
            {
                result *= 10;
                result += x % 10;

                x /= 10;
            }

            return result;
        }
    }
}