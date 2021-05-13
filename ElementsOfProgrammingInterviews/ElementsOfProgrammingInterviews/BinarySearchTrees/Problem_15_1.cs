using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    public class Problem_15_1
    {
        public bool Solution(BinaryTreeNode root)
        {
            return InRange(root, int.MinValue, int.MaxValue);
        }

        private bool InRange(BinaryTreeNode node, int minValue, int maxValue)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Data < minValue || node.Data > maxValue)
            {
                return false;
            }

            return InRange(node.Left, minValue, node.Data) &&
                   InRange(node.Right, node.Data, maxValue);
        }
    }
}