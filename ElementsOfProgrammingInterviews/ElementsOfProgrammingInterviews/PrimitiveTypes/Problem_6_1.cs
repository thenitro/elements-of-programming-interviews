using System;

namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_6_1
    {
        public void Solution(int[] array)
        {
            if (array == null)
            {
                return;
            }
            
            var start = 0;
            var middle = 0;
            var end = array.Length - 1;

            while (middle < end)
            {
                if (array[middle] == 2)
                {
                    Swap(middle, end, array);
                    end--;
                } 
                else if (array[middle] == 1)
                {
                    middle++;
                }
                else if (array[middle] == 0)
                {
                    Swap(middle, start, array);
                    start++;
                }
            }
        }

        private void Swap(int a, int b, int[] array)
        {
            var tmp = array[a];
            array[a] = array[b];
            array[b] = tmp;
        }
    }
}