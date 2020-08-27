namespace ElementsOfProgrammingInterviews.Searching
{
    public class Problem_12_4
    {
        public int Solution(int n)
        {
            var l = 1;
            var r = n - 1;
            var m = n;

            while (l <= r)
            {
                m = l + (r - l) / 2;

                if (m * m > n)
                {
                    r = m - 1;
                } 
                else if (m * m == n)
                {
                    return m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return m;
        }
    }
}