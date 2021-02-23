namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_3
    {
        public int Solution(string column)
        {
            var result = 0;

            foreach (var c in column)
            {
                result = result * 26 + c - 'A' + 1;
            }

            return result;
        }
    }
}