namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_5
    {
        public int Solution(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            var writeIndex = 1;

            for (var i = 1; i < array.Length; i++)
            {
                if (array[writeIndex - 1] != array[i])
                {
                    array[writeIndex++] = array[i];
                }
            }

            return writeIndex;
        }
    }
}