namespace ElementsOfProgrammingInterviews.Searching
{
    public class Problem_12_3
    {
        public int Solution(int[] array)
        {
            var l = 0;
            var r = array.Length - 1;

            while (l < r)
            {
                var m = l + (r - l) / 2;

                if (array[m] > array[r])
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            return l;
        }
    }
}