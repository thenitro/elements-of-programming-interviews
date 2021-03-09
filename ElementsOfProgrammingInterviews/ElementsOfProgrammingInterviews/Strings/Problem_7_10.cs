using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_10
    {
        public List<string> Solution(string input)
        {
            var result = new List<string>();

            for (var i = 1; i < 4 && i < input.Length; i++)
            {
                var first = input.Substring(0, i);

                if (!IsValid(first))
                {
                    continue;
                }
                
                for (var j = 1; i + j < input.Length && j < 4; j++)
                {
                    var second = input.Substring(i, j);

                    if (!IsValid(second))
                    {
                        continue;
                    }

                    for (var k = 1; i + j + k < input.Length && k < 4; k++)
                    {
                        var third = input.Substring(i + j, k);
                        var fourth = input.Substring(i + j + k);

                        if (!IsValid(third) || !IsValid(fourth))
                        {
                            continue;
                        }
                        
                        result.Add($"{first}.{second}.{third}.{fourth}");
                    }
                }
            }

            return result;
        }

        private bool IsValid(string input)
        {
            if (input.Length > 3)
            {
                return false;
            }

            if (input[0] == '0' && input.Length > 1)
            {
                return false;
            }

            var value = Convert.ToInt32(input);
            return value >= 0 && value <= 255;
        }
    }
}