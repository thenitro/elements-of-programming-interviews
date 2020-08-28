using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.HashTables
{
    public class Problem_13_6
    {
        public int Solution(string[] words)
        {
            var min = int.MaxValue;
            var dict = new Dictionary<string, int>();

            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];
                
                if (dict.ContainsKey(word))
                {
                    var diff = i - dict[word];
                    min = Math.Min(diff, min);
                }

                dict[word] = i;
            }

            return min;
        }
    }
}