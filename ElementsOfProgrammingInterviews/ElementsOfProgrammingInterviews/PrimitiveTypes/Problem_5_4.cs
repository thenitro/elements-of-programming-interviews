namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_4
    {
        public int Solution(int x)
        {
            var countX = PopCount(x);
            var left = x - 1;
            var right = x + 1;

            while (true)
            {
                if (PopCount(left) == countX)
                {
                    return left;
                }
                
                if (PopCount(right) == countX)
                {
                    return right;
                }

                left--;
                right++;
            }

            return -1;
        }

        private int PopCount(int x)
        {
            var count = 0;

            while (x != 0)
            {
                x &= x - 1;
                count++;
            }

            return count;
        }
    }
}