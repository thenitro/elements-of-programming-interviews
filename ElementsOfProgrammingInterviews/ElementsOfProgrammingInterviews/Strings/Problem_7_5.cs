namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_5
    {
        public bool Solution(string s)
        {
            var start = 0;
            var end = s.Length - 1;

            while (start < end)
            {
                while (!char.IsLetterOrDigit(s[start]) && start < end)
                {
                    start++;
                }

                while (!char.IsLetterOrDigit(s[end]) && start < end)
                {
                    end--;
                }

                if (char.ToLower(s[start]) != char.ToLower(s[end]))
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}