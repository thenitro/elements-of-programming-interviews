using System;

namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_6
    {
        public int Solution(int x, int y)
        {
            var hasNegative = (x > 0 && y < 0) || (x < 0 && y > 0);
            var result = 0;

            x = Math.Abs(x);
            y = Math.Abs(y);

            while (x > 0)
            {
                x -= y;
                result++;
            }

            return hasNegative ? result * -1 : result;
        }
    }
}