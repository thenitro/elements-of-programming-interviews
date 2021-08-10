using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_8
    {
        public List<int> Solution(BinaryTreeNode<int> root)
        {
            var stack = new Stack<BinaryTreeNode<int>>();
                stack.Push(root);

            var result = new List<int>();

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node == null)
                {
                    continue;
                }
                
                result.Add(node.Data);
                
                stack.Push(node.Right);
                stack.Push(node.Left);
            }
            
            return result;
        }
    }
}