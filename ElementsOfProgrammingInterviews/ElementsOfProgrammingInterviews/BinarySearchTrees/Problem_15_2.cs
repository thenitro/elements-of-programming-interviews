using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    public class Problem_15_2
    {
        public BinaryTreeNode Solution(BinaryTreeNode node, int k)
        {
            BinaryTreeNode firstBigger = null;
            
            while (node != null)
            {
                if (node.Data > k)
                {
                    firstBigger = node;
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }

            return firstBigger;
        }
    }
}