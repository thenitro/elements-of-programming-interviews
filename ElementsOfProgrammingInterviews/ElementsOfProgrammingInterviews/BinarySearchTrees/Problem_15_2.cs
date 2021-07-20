using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    public class Problem_15_2
    {
        public BinaryTreeNode<int> Solution(BinaryTreeNode<int> node, int k)
        {
            BinaryTreeNode<int> firstBigger = null;
            
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