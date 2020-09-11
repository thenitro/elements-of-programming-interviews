using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.Heaps
{
    public class Problem_11_3
    {
        public void Solution(int[] array, int k)
        {
            var heap = new MinHeap<int>();

            for (var i = 0; i < k; i++)
            {
                heap.Push(array[i], array[i]);
            }

            var counter = k;
            
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = heap.Pop().Data;

                if (counter < array.Length)
                {
                    heap.Push(array[counter], array[counter]);
                    counter++;
                }
            }
        }
    }
}