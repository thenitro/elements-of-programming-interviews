using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.GreedyAlgorithmsAndInvariants
{
    public class Problem_18_4
    {
        public bool Solution(int[] array, int sum)
        {
            Array.Sort(array);

            var set = new HashSet<int>();

            foreach (var i in array)
            {
                if (!set.Contains(i))
                {
                    set.Add(i);
                }
            }

            foreach (var a in array)
            {
                if (HasTwoSum(set, array, sum - a))
                {
                    return true;
                }
            }

            return false;
        }

        private bool HasTwoSum(HashSet<int> set, int[] array, int sum)
        {
            foreach (var b in array)
            {
                var c = sum - b;

                if (set.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }
    }
}