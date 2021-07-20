using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_1
    {
        public bool Solution(BinaryTreeNode<int> root)
        {
            return IsBalanced(root).Item1;
        }

        private Tuple<bool, int> IsBalanced(BinaryTreeNode<int> node)
        {
            if (node == null)
            {
                return new Tuple<bool, int>(true, 0);
            }

            var left = IsBalanced(node.Left);
            if (!left.Item1)
            {
                return new Tuple<bool, int>(false, 0);
            }
            
            var right = IsBalanced(node.Right);
            if (!right.Item1)
            {
                return new Tuple<bool, int>(false, 0);
            }

            var diff = Math.Abs(left.Item2 - right.Item2);
            var isBalanced = diff <= 1;
            
            return new Tuple<bool, int>(isBalanced, Math.Max(left.Item2, right.Item2) + 1);
        }
    }
}