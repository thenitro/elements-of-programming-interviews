using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    public class Problem_15_1
    {
        public bool Solution(BinaryTreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            var result = true;
            
            if (root.Left != null)
            {
                result = root.Left.Data <= root.Data && Solution(root.Left);
            }

            if (root.Right != null)
            {
                result &= root.Right.Data > root.Data && Solution(root.Right);
            }

            return result;
        }
    }
}