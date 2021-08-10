using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_3
    {
        private BinaryTreeNode<int> _result;

        public BinaryTreeNode<int> Solution(BinaryTreeNode<int> root, 
            BinaryTreeNode<int> nodeA, BinaryTreeNode<int> nodeB)
        {
            SolutionHelper(root, nodeA, nodeB);
            return _result;
        }

        public int SolutionHelper(BinaryTreeNode<int> node, 
            BinaryTreeNode<int> nodeA, BinaryTreeNode<int> nodeB)
        {
            if (node == null)
            {
                return 0;
            }

            if (node == nodeA || node == nodeB)
            {
                return 1;
            }

            var leftNode = SolutionHelper(node.Left, nodeA, nodeB);
            var rightNode = SolutionHelper(node.Right, nodeA, nodeB);

            if (leftNode + rightNode == 2)
            {
                _result = node;

                return 3;
            }

            return leftNode + rightNode;
        }
    }
}