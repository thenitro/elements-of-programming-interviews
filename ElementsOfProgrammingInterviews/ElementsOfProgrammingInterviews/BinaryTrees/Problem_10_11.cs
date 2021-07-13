using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_11
    {
        public List<int> Solution(BinaryTreeNode tree)
        {
            BinaryTreeNode prev = null;
            var current = tree;
            var result = new List<int>();

            while (current != null)
            {
                BinaryTreeNode next = null;

                if (current.Parent == prev)
                {
                    if (current.Left != null)
                    {
                        next = current.Left;
                    }
                    else
                    {
                        result.Add(current.Data);
                        next = current.Right == null ? current.Parent : current.Right;
                    }
                }
                else if (current.Left == prev)
                {
                    result.Add(current.Data);
                    next = current.Right == null ? current.Parent : current.Right;
                }
                else
                {
                    next = current.Parent;
                }

                prev = current;
                current = next;
            }

            return result;
        }
    }
}