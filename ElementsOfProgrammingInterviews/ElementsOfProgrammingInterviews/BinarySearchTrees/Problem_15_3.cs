using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    public class Problem_15_3
    {
        public List<BinaryTreeNode<int>> Solution(BinaryTreeNode<int> node, int k)
        {
            var result = new List<BinaryTreeNode<int>>();

            SolutionHelper(node, k, result);

            return result;
        }

        private void SolutionHelper(BinaryTreeNode<int> node, int k, List<BinaryTreeNode<int>> result)
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