using System;

namespace ElementsOfProgrammingInterviews.Searching
{
    public class Problem_12_5
    {
        public double Solution(double x)
        {
            var lessThanOne = x < 1.0;
            
            var left = lessThanOne ? x : 1.0;
            var right = lessThanOne ? 1.0 : x;

            while (Compare(left, right) == Ordering.Smaller)
            {
                var mid = left + 0.5 * (right - left);
                var midSquared = mid * mid;

                var comparison = Compare(midSquared, x);

                if (comparison == Ordering.Equal)
                {
                    return mid;
                }
                else if (comparison == Ordering.Larger)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }

            return left;
        }

        private Ordering Compare(double a, double b)
        {
            var diff = (a - b) / b;
            return diff < -Double.Epsilon
                ? Ordering.Smaller
                : diff > Double.Epsilon
                    ? Ordering.Larger
                    : Ordering.Equal;
        }

        private enum Ordering
        {
            Smaller,
            Equal,
            Larger,
        }
    }
}