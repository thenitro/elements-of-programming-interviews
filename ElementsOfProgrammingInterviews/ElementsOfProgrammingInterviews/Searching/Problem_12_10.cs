using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.Searching
{
    public class Problem_12_10
    {
        public DuplicateAndMissing Solution(int[] array)
        {
            var result = new DuplicateAndMissing();
            var set = new HashSet<int>();

            foreach (var i in array)
            {
                if (set.Contains(i))
                {
                    result.Duplicate = i;
                    continue;
                }

                set.Add(i);
            }

            for (var i = 0; i < array.Length; i++)
            {
                if (set.Contains(i))
                {
                    continue;
                }

                result.Missing = i;
            }

            return result;
        }
    }
}