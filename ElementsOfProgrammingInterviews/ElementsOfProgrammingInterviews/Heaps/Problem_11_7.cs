using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.Heaps
{
    public class Problem_11_7<T>
    {
        private MinHeap<T> _heap = new MinHeap<T>();

        public void Push(T x)
        {
            _heap.Push(-DateTime.Now.Ticks, x);
        }

        public T Pop()
        {
            return _heap.Pop().Data;
        }

        public T Peek()
        {
            return _heap.Peek().Data;
        }
    }
}