using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_2
    {
        public bool Solution(BinaryTreeNode<int> root)
        {
            return CheckIsEqual(root.Left, root.Right);
        }

        private bool CheckIsEqual(BinaryTreeNode<int> nodeA, BinaryTreeNode<int> nodeB)
        {
            if (nodeA == null && nodeB == null)
            {
                return true;
            }
            
            if ((nodeA == null && nodeB != null) || (nodeA != null && nodeB == null))
            {
                return false;
            }

            if (nodeA.Data != nodeB.Data)
            {
                return false;
            }

            return CheckIsEqual(nodeA.Left, nodeB.Right) && CheckIsEqual(nodeA.Right, nodeB.Left);
        }
    }
}