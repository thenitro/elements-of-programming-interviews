using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    public class Problem_16_1
    {
        private Stack<int>[] _stacks;
        
        public Problem_16_1(Stack<int> a, Stack<int> b, Stack<int> c)
        {
            _stacks = new Stack<int>[] { a, b, c };
        }
        
        public void Solution(int n, int from, int to, int aux)
        {
            if (n == 0)
            {
                return;
            }

            Solution(n - 1, from, aux, to);
            
            var item = _stacks[from].Pop();
            _stacks[to].Push(item);
            
            Solution(n - 1, aux, to, from);
        }
    }
}