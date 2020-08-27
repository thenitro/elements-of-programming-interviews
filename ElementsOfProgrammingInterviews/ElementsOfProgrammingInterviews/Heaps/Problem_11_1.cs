using System;
using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.Heaps
{
    public class Problem_11_1
    {
        public List<int> Solution(int[][] array)
        {
            var iterators = new Queue<ArrayIterator>();
            var heap = new MinHeap<int>();
            
            for (var i = 0; i < array.Length; i++)
            {
                var iterator = new ArrayIterator(array[i]);
                
                iterators.Enqueue(iterator);
                var next = iterator.Next(); 
                heap.Push(next, next);
            }
            
            var result = new List<int>();

            while (heap.Count > 0)
            {
                if (iterators.Count > 0)
                {
                    var iterator = iterators.Dequeue();
                    var next = iterator.Next();
                    heap.Push(next, next);

                    if (iterator.HasNext())
                    {
                        iterators.Enqueue(iterator);
                    }
                }
                
                result.Add(heap.Pop().Data);
            }
            
            return result;
        }

        private class ArrayIterator
        {
            private int[] _array;
            private int _index;

            public ArrayIterator(int[] array)
            {
                _array = array;
                _index = -1;
            }

            public bool HasNext()
            {
                Console.WriteLine(_index + " " + _array.Length);
                
                return _index < _array.Length - 1;
            }

            public int Next()
            {
                return _array[++_index];
            }
        }
    }
}