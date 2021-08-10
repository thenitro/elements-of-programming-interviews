using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_6
    {
        public bool Solution(BinaryTreeNode<int> node, int sum)
        {
            return SolutionHelper(node, sum, 0);
        }

        private bool SolutionHelper(BinaryTreeNode<int> node, int sum, int currentSum)
        {
            if (node == null)
            {
                return false;
            }

            currentSum += node.Data;

            if (node.Left == null && node.Right == null)
            {
                return currentSum == sum;
            }

            return SolutionHelper(node.Left, sum, currentSum) ||
                   SolutionHelper(node.Right, sum, currentSum);
        }
    }
}