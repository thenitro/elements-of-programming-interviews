using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_4
    {
        public BinaryTreeNode<int> Solution(BinaryTreeNode<int> a, BinaryTreeNode<int> b)
        {
            var iterA = a;
            var iterB = b;

            var depthA = GetDepth(a);
            var depthB = GetDepth(b);

            if (depthB > depthA)
            {
                var tmp = iterA;
                iterA = iterB;
                iterB = tmp;
            }

            var diff = Math.Abs(depthA - depthB);
            while (diff > 0)
            {
                iterA = iterA.Parent;
                diff--;
            }

            while (iterA != iterB)
            {
                iterA = iterA.Parent;
                iterB = iterB.Parent;
            }

            return iterA;
        }

        private int GetDepth(BinaryTreeNode<int> node)
        {
            var depth = 0;

            while (node != null)
            {
                node = node.Parent;
                depth++;
            }

            return depth;
        }
    }
}