using System;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_8
    {
        private int _size;
        private int[] _storage;

        private int _start;
        private int _end;
        
        public Problem_9_8(int size)
        {
            _size = size;
            _storage = new int[size];

            _start = 0;
            _end = 0;
        }
        
        public void Enqueue(int x)
        {
            if (_end == _size)
            {
                var newArray = new int[_size * 2];

                var j = 0;
                for (var i = 0; i < _end; i++)
                {
                    newArray[j++] = _storage[i];
                }

                _storage = newArray;
            }
            
            _storage[_end++] = x;
        }

        public int Dequeue()
        {
            if (_start == _end)
            {
                _start = 0;
            }
            
            return _storage[_start++];
        }
    }
}