namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_13
    {
        public int Solution(string input, string search)
        {
            var startSearch = 0;

            for (var i = 0; i < input.Length; i++)
            {
                var found = true;
                
                for (var j = 0; j < search.Length; j++)
                {
                    if (input[i + j] != search[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}