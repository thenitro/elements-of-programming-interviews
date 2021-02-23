using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_7
    {
        private Dictionary<char, char[]> Phone = new Dictionary<char, char[]>()
        {
            {'1', new char[0] },
            {'2', new [] { 'A', 'B', 'C' }},
            {'3', new [] { 'D', 'E', 'F' }},
            {'4', new [] { 'G', 'H', 'I' }},
            {'5', new [] { 'J', 'K', 'L' }},
            {'6', new [] { 'M', 'N', 'O' }},
            {'7', new [] { 'P', 'Q', 'R', 'S' }},
            {'8', new [] { 'T', 'U', 'V' }},
            {'9', new [] { 'W', 'X', 'Y', 'Z' }},
            {'0', new char[0] },
        };

        public List<string> Solution(string number)
        {
            var result = new List<string>();

            SolutionHelper(string.Empty, 0, number, result);
            
            return result;
        }

        private void SolutionHelper(string current, int index, string number, List<string> result)
        {
            if (index == number.Length)
            {
                result.Add(current);
                return;
            }

            var possibleChars = Phone[number[index]];

            foreach (var possibleChar in possibleChars)
            {
                SolutionHelper(current + possibleChar, index + 1, number, result);
            }
        }
    }
}