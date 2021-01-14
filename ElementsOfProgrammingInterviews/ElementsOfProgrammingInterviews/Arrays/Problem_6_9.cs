namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_9
    {
        public char[] Solution(char[] A, int[] P)
        {
            var result = new char[A.Length];

            for (var i = 0; i < A.Length; i++)
            {
                result[P[i]] = A[i];
            }

            return result;
        }
    }
}