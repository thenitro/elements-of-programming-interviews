using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_9
    {
        public List<int> Solution(BinaryTreeNode<int> root, int k)
        {
            var stack = new Stack<BinaryTreeNode<int>>();
                stack.Push(root);
                
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
                    
                    if (result.Count == k)
                    {
                        return result;
                    }

                    current = current.Right;
                }
            }

            return result;
        }
    }
}