namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_4
    {
        public bool Solution(int[] input)
        {
            return SolutionHelper(input, 0);
        }

        private bool SolutionHelper(int[] input, int position)
        {
            if (position >= input.Length)
            {
                return false;
            }
            
            if (position == input.Length - 1)
            {
                return true;
            }

            if (input[position] == 0)
            {
                return false;
            }

            for (var i = 1; i <= input[position]; i++)
            {
                if (SolutionHelper(input, position + i))
                {
                    return true;
                }
            }

            return false;
        }
    }
}