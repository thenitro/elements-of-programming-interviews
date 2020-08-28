using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.HashTables
{
    public class Problem_13_2
    {
        public bool Solution(string letter, string magazine)
        {
            var dict = new Dictionary<char, int>();

            foreach (var c in letter)
            {
                dict[c] = dict.ContainsKey(c) ? dict[c] + 1 : 1;
            }

            foreach (var c in magazine)
            {
                if (!dict.ContainsKey(c))
                {
                    continue;
                }

                dict[c] -= 1;

                if (dict[c] == 0)
                {
                    dict.Remove(c);
                }
            }

            return dict.Count == 0;
        }
    }
}