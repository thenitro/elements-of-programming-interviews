using System;

namespace ElementsOfProgrammingInterviews.Searching
{
    public class Problem_12_8
    {
        public int Solution(int k, int[] array)
        {
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var random = new Random();
                var pivotIndex = random.Next(left, right);
                
                var newPivotIndex = PartitionAroundPivot(left, right, pivotIndex, array);
                if (newPivotIndex == k - 1)
                {
                    return array[newPivotIndex];
                } 
                else if (newPivotIndex > k - 1)
                {
                    right = newPivotIndex - 1;
                }
                else
                {
                    left = newPivotIndex + 1;
                }
            }

            return -1;
        }

        private int PartitionAroundPivot(int left, int right, int pivotIndex, int[] array)
        {
            var pivotValue = array[pivotIndex];
            var newPivotIndex = left;

            Swap(pivotIndex, right, array);
            
            for (var i = left; i < right; i++)
            {
                if (array[i] > pivotValue)
                {
                    Swap(i, newPivotIndex, array);
                    newPivotIndex++;
                }
            }
            
            Swap(right, newPivotIndex, array);

            return newPivotIndex;
        }

        private void Swap(int i, int j, int[] array)
        {
            var tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}