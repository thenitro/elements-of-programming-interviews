using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    public class Problem_15_3
    {
        public List<BinaryTreeNode> Solution(BinaryTreeNode node, int k)
        {
            var result = new List<BinaryTreeNode>();

            SolutionHelper(node, k, result);

            return result;
        }

        private void SolutionHelper(BinaryTreeNode node, int k, List<BinaryTreeNode> result)
        {
            if (node == null)
            {
                return;
            }
            
            if (k == result.Count)
            {
                return;
            }
            
            SolutionHelper(node.Right, k, result);

            if (k != result.Count)
            {
                result.Add(node);
            }
            
            SolutionHelper(node.Left, k, result);
        }
    }
}