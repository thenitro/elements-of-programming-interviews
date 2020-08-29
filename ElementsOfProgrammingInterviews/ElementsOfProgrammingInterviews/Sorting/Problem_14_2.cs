namespace ElementsOfProgrammingInterviews.Sorting
{
    public class Problem_14_2
    {
        public void Solution(int[] a, int[] b, int n, int m)
        {
            var writeIndex = n + m - 1;
            var i = n - 1;
            var j = m - 1;

            while (i >= 0 && j >= 0)
            {
                if (a[i] > b[j])
                {
                    a[writeIndex--] = a[i];
                    i--;
                }
                else
                {
                    a[writeIndex--] = b[j];
                    j--;
                }
            }

            while (j >= 0)
            {
                a[writeIndex--] = b[j];
                j--;
            }
        }
    }
}