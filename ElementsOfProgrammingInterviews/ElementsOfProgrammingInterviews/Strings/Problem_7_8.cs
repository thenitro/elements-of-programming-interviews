namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_8
    {
        public string Solution(int n)
        {
            var s = "1";

            for (var i = 1; i < n; i++)
            {
                s = NextNumber(s);
            }

            return s;
        }

        private string NextNumber(string s)
        {
            var result = string.Empty;

            for (var i = 0; i < s.Length; i++)
            {
                var count = 1;

                while (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    i++;
                    count++;
                }

                result += $"{count}{s[i]}";
            }
            
            return result;
        }
    }
}