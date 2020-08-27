using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_1
    {
        public bool Solution(BinaryTreeNode root)
        {
            var diff = Math.Abs(SolutionHelper(root.Left) - SolutionHelper(root.Right));
            return diff <= 1;
        }

        private int SolutionHelper(BinaryTreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(SolutionHelper(node.Left), SolutionHelper(node.Right));
        }
    }
}