using System;
using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.Heaps
{
    public class Problem_11_2
    {
        public List<int> Solution(int[] input)
        {
            var sortedSubarrays = new List<List<int>>();
            var increasing = true;
            var startIndex = 0;

            for (var i = 1; i <= input.Length; i++)
            {
                Console.WriteLine(i);
                
                if (i == input.Length ||
                    (input[i - 1] < input[i] && !increasing) ||
                    (input[i - 1] >= input[i] && increasing))
                {
                    var newList = new List<int>();
                    
                    if (increasing)
                    {
                        for (var j = startIndex; j < i; j++)
                        {
                            newList.Add(input[j]);
                        }
                    }
                    else
                    {
                        for (var j = i - 1; j >= startIndex; j--)
                        {
                            newList.Add(input[j]);
                        }
                    }
                    
                    sortedSubarrays.Add(newList);

                    startIndex = i;
                    increasing = !increasing;
                }
            }

            var queue = new Queue<ArrayIterator>();
            var heap = new MinHeap<int>();
            
            foreach (var sortedSubarray in sortedSubarrays)
            {
                var iterator = new ArrayIterator() { Index = 0, List = sortedSubarray };
                queue.Enqueue(iterator);
                var next = iterator.Next();
                heap.Push(next, next);
            }

            var result = new List<int>();

            while (heap.Count > 0)
            {
                if (queue.Count > 0)
                {
                    var array = queue.Dequeue();
                    var value = array.Next();
                
                    heap.Push(value, value);

                    if (array.HasNext())
                    {
                        queue.Enqueue(array);
                    }
                }
                
                result.Add(heap.Pop().Data);
            }
            
            return result;
        }

        private class ArrayIterator
        {
            public int Index;
            public List<int> List;

            public bool HasNext()
            {
                return Index < List.Count;
            }

            public int Next()
            {
                return List[Index++];
            }
        }
    }
}