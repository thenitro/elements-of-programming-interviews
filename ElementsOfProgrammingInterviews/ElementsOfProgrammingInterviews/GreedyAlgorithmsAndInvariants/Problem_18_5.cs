namespace ElementsOfProgrammingInterviews.GreedyAlgorithmsAndInvariants
{
    public class Problem_18_5
    {
        public string Solution(string[] array)
        {
            var element = string.Empty;
            var counter = 0;

            foreach (var s in array)
            {
                if (counter == 0)
                {
                    element = s;
                    counter = 1;
                }

                if (element == s)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
            }
            
            return element;
        }
    }
}