using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_4
    {
        public BinaryTreeNode Solution(BinaryTreeNode a, BinaryTreeNode b)
        {
            var set = new HashSet<BinaryTreeNode>();
            var node = a;

            while (node != null)
            {
                set.Add(node);
                node = node.Parent;
            }

            node = b;
            while (node != null)
            {
                if (set.Contains(node))
                {
                    return node;
                }

                node = node.Parent;
            }

            return null;
        }
    }
}