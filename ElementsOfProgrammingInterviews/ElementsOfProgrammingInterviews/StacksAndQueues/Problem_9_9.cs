using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_9
    {
        private Stack<int> _enqueue = new Stack<int>();
        private Stack<int> _dequeue = new Stack<int>();
        
        public void Enqueue(int x)
        {
            _enqueue.Push(x);
        }

        public int Dequeue()
        {
            if (_dequeue.Count == 0)
            {
                while (_enqueue.Count > 0)
                {
                    _dequeue.Push(_enqueue.Pop());
                }
            }

            if (_dequeue.Count == 0)
            {
                return 0;
            }

            return _dequeue.Pop();
        }
    }
}