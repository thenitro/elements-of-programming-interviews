using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_1
    {
        private int _size;
        private int _i;
        private int[] _array;
        private int _max;
        private Dictionary<int, int> _maxes;
        
        public Problem_9_1(int size)
        {
            _max = int.MinValue;
            _size = size;
            _array = new int[_size];
            _maxes = new Dictionary<int, int>();
        }

        public int Max => _max;
        
        public void Push(int x)
        {
            if (_i == _size)
            {
                return;
            }

            _array[_i] = x;
            _max = Math.Max(x, _max);
            _maxes[x] = _max;
            _i++;
        }

        public int Pop()
        {
            if (_i == 0)
            {
                return 0;
            }

            _i--;

            var x = _array[_i];
            if (x == _max)
            {
                if (_i != 0)
                {
                    _max = _maxes[_array[_i - 1]];
                }
                else
                {
                    _max = int.MinValue;
                }
            }

            return x;
        }
    }
}