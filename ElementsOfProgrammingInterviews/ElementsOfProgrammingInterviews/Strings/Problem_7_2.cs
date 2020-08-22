namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_2
    {
        public string Solution(string s, int b1, int b2)
        {
            var isNegative = s[0] == '-';
            var x = 0;

            for (var i = isNegative ? 1 : 0; i < s.Length; i++)
            {
                x *= b1;
                x += char.IsDigit(s[i]) ? s[i] - '0' : s[i] - 'A' + 10;
            }

            return isNegative ? "-" : "" + (x == 0 ? "0" : ConstructFromBase(x, b2));
        }

        private string ConstructFromBase(int x, int b)
        {
            return x == 0 ? "" : ConstructFromBase(x / b, b) + (char)(x % b >= 10 ? 'A' + x % b - 10 : '0' + x % b);
        }
    }
}