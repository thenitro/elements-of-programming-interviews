using System.Text;

namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_11
    {
        public string Solution(string input)
        {
            var result = new StringBuilder();

            for (var i = 1; i < input.Length; i += 4)
            {
                result.Append(input[i]);
            }
            
            for (var i = 0; i < input.Length; i += 2)
            {
                result.Append(input[i]);
            }
            
            for (var i = 3; i < input.Length; i += 4)
            {
                result.Append(input[i]);
            }

            return result.ToString();
        }
    }
}