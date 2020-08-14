using System;

namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_7
    {
        public double Solution(double x, int y)
        {
            var result = 1.0;

            for (var i = 0; i < Math.Abs(y); i++)
            {
                if (y > 0)
                {
                    result *= x;
                }
                else
                {
                    result /= x;
                }
            }

            return result;
        }
    }
}