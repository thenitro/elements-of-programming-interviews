using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.HashTables
{
    public class Problem_13_4
    {
        public BinaryTreeNode Solution(BinaryTreeNode a, BinaryTreeNode b)
        {
            var set = new HashSet<BinaryTreeNode>();

            while (a != null || b != null)
            {
                if (a != null)
                {
                    if (set.Contains(a))
                    {
                        return a;
                    }

                    set.Add(a);
                    a = a.Parent;
                }

                if (b != null)
                {
                    if (set.Contains(b))
                    {
                        return b;
                    }

                    set.Add(b);
                    b = b.Parent;
                }
            }

            return null;
        }
    }
}