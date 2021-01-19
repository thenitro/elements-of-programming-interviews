using System;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_10
    {
        public int[] Solution(int[] perm)
        {
            var k = perm.Length - 2;

            while (k >= 0 && perm[k] >= perm[k + 1])
            {
                k--;
            }

            if (k == -1)
            {
                return new int[0];
            }

            for (var i = perm.Length - 1; i > k; i--)
            {
                if (perm[i] > perm[k])
                {
                    Swap(k, i, perm);
                    break;
                }
            }

            Reverse(k + 1, perm.Length - 1, perm);

            Console.WriteLine(string.Join(",", perm));
            
            return perm;
        }

        private void Swap(int i, int j, int[] array)
        {
            var tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }

        private void Reverse(int start, int end, int[] array)
        {
            while (start < end)
            {
                Swap(start, end, array);
                
                start++;
                end--;
            }
        }
    }
}