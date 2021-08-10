using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_7
    {
        public List<int> Solution(BinaryTreeNode<int> root)
        {
            var stack = new Stack<BinaryTreeNode<int>>();
            var current = root;
            var result = new List<int>();

            while (stack.Count > 0 || current != null)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else
                {
                    current = stack.Pop();
                    result.Add(current.Data);
                    current = current.Right;
                }
            }

            return result;
        }
    }
}