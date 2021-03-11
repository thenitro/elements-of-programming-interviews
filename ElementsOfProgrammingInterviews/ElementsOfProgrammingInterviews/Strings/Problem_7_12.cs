using System.Text;

namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_12
    {
        public string Decode(string input)
        {
            var result = new StringBuilder();
            var count = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var character = input[i];
                
                if (char.IsDigit(character))
                {
                    count = character - '0';
                }
                else
                {
                    for (var j = 0; j < count; j++)
                    {
                        result.Append(character);
                    }
                }
            }

            return result.ToString();
        }

        public string Encode(string input)
        {
            var result = new StringBuilder();
            var count = 1;

            for (var i = 1; i <= input.Length; i++)
            {
                if (i == input.Length || input[i] != input[i - 1])
                {
                    result.Append(count);
                    result.Append(input[i - 1]);
                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            return result.ToString();
        }
    }
}