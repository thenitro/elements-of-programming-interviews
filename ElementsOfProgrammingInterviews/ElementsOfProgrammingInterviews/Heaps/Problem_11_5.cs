using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.Heaps
{
    public class Problem_11_5
    {
        private MinHeap<int> _minHeap = new MinHeap<int>();
        private MinHeap<int> _maxHeap = new MinHeap<int>();

        public double Solution(int x)
        {
            if (_minHeap.Count == 0)
            {
                _minHeap.Push(x, x);
            }
            else
            {
                if (x >= _minHeap.Peek().Data)
                {
                    _minHeap.Push(x, x);
                }
                else
                {
                    _maxHeap.Push(-x, x);
                }
            }

            if (_minHeap.Count > _maxHeap.Count + 1)
            {
                var min = _minHeap.Pop().Data;
                _maxHeap.Push(-min, min);
            }
            else if (_maxHeap.Count > _minHeap.Count)
            {
                var max = _maxHeap.Pop().Data;
                _minHeap.Push(max, max);
            }

            return _minHeap.Count == _maxHeap.Count
                ? 0.5 * (_minHeap.Peek().Data + _maxHeap.Peek().Data)
                : _minHeap.Peek().Data;
        }
    }
}