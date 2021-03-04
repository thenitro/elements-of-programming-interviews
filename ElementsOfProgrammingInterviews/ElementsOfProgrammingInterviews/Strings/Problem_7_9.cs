using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_9
    {
        private readonly Dictionary<char, int> _symbols = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };
        
        public int Solution(string input)
        {
            var sum = _symbols[input[input.Length - 1]];

            for (var i = input.Length - 2; i >= 0; i--)
            {
                var currentNominal = _symbols[input[i]];
                var nextNominal = _symbols[input[i + 1]];

                if (currentNominal < nextNominal)
                {
                    sum -= currentNominal;
                }
                else
                {
                    sum += currentNominal;
                }
            }
            
            return sum;
        }
    }
}