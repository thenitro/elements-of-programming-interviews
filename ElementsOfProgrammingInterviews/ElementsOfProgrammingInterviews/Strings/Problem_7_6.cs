using System;

namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_6
    {
        public void Solution(char[] s)
        {
            Reverse(0, s.Length - 1, s);

            var start = 0;
            
            for (var i = 0; i <= s.Length; i++)
            {
                if (i == s.Length || s[i] == ' ')
                {
                    Reverse(start, i - 1, s);
                    start = i + 1;
                }
            }
        }

        private void Reverse(int l, int r, char[] s)
        {
            while (l < r)
            {
                Swap(l, r, s);
                l++;
                r--;
            }
        }

        private void Swap(int a, int b, char[] s)
        {
            var tmp = s[a];
            s[a] = s[b];
            s[b] = tmp;
        }
    }
}