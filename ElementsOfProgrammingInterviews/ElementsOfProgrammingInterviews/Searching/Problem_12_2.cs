namespace ElementsOfProgrammingInterviews.Searching
{
    public class Problem_12_2
    {
        public int Solution(int[] array)
        {
            var l = 0;
            var r = array.Length;

            while (l < r)
            {
                var m = l + (r - l) / 2;

                if (array[m] > m)
                {
                    r = m - 1;
                }
                else if (array[m] < m)
                {
                    l = m + 1;
                }
                else
                {
                    return m;
                }
            }

            return -1;
        }
    }
}