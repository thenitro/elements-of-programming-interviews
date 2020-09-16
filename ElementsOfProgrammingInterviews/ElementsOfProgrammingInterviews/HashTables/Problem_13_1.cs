using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.HashTables
{
    public class Problem_13_1
    {
        public bool Solution(string input)
        {
            var amountOfOdds = input.Length % 2;
            var dict = new Dictionary<char, int>();

            foreach (var c in input)
            {
                dict[c] = dict.ContainsKey(c) ? dict[c] + 1 : 1;
            }

            foreach (var kv in dict)
            {
                if (kv.Value % 2 == 1)
                {
                    if (amountOfOdds == 0)
                    {
                        return false;
                    }
                    
                    amountOfOdds--;
                }
            }

            return true;
        }
    }
}