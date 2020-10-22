namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_9
    {
        public bool Solution(int x)
        {
            if (x < 0)
            {
                return false;
            }

            if (x == 0)
            {
                return true;
            }

            return Reverse(x) == x;
        }

        private int Reverse(int x)
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