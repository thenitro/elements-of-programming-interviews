using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Graphs
{
    public class Problem_19_7
    {
        public int Solution(HashSet<string> dict, string s, string t)
        {
            var queue = new Queue<Candidate>();
            dict.Remove(s);
            queue.Enqueue(new Candidate(s, 0));

            while (queue.Count > 0)
            {
                var candidate = queue.Dequeue();
                if (candidate.S == t)
                {
                    return candidate.Distance;
                }

                var str = candidate.S.ToCharArray();
                for (var i = 0; i < str.Length; i++)
                {
                    for (var j = 0; j < 26; j++)
                    {
                        str[i] = (char)('a' + j);

                        var newStr = new string(str);

                        if (dict.Contains(newStr))
                        {
                            dict.Remove(newStr);
                            queue.Enqueue(new Candidate(newStr, candidate.Distance + 1));
                        }
                    }

                    str[i] = candidate.S[i];
                }
            }

            return -1;
        }
        
        private struct Candidate
        {
            public string S;
            public int Distance;

            public Candidate(string s, int distance)
            {
                S = s;
                Distance = distance;
            }
        }
    }
}