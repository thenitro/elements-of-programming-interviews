using System;

namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_1
    {
        public int StringToInt(string s)
        {
            var result = 0;
            var sign = s[0] == '-';
            
            for (var i = sign ? 1 : 0; i < s.Length; i++)
            {
                result *= 10;
                result += s[i] - '0';
            }

            return result * (sign ? -1 : 1);
        }

        public string IntToString(int i)
        {
            if (i == 0)
            {
                return "0";
            }
            
            var sign = i >= 0;
            var abs = Math.Abs(i);

            var result = string.Empty;
            
            while (abs != 0)
            {
                var c = abs % 10;
                abs /= 10;

                result = c + result;
            }

            if (!sign)
            {
                result = "-" + result;
            }

            return result;
        }
    }
}