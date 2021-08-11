using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_10
    {
        public BinaryTreeNode<int> Solution(BinaryTreeNode<int> node)
        {
            if (node.Right == null)
            {
                while (node.Parent != null && node.Parent.Right == node)
                {
                    node = node.Parent;
                }
            }
            else
            {
                while (node.Left != null)
                {
                    node = node.Left;
                }
            }

            return node;
        }
    }
}