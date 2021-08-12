using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_15
    {
        public List<BinaryTreeNode<int>> Solution(BinaryTreeNode<int> root)
        {
            var exterior = new List<BinaryTreeNode<int>>();

            if (root != null)
            {
                exterior.Add(root);
                exterior.AddRange(LeftBoundaryAndLeaves(root.Left, true));
                exterior.AddRange(RightBoundaryAndLeaves(root.Right, true));
            }

            return exterior;
        }

        private List<BinaryTreeNode<int>> LeftBoundaryAndLeaves(BinaryTreeNode<int> node, bool isBoundary)
        {
            var result = new List<BinaryTreeNode<int>>();

            if (node != null)
            {
                if (isBoundary || IsLeaf(node))
                {
                    result.Add(node);
                }
                
                result.AddRange(LeftBoundaryAndLeaves(node.Left, isBoundary));
                result.AddRange(LeftBoundaryAndLeaves(node.Right, isBoundary && node.Left == null));
            }

            return result;
        }
        
        private List<BinaryTreeNode<int>> RightBoundaryAndLeaves(BinaryTreeNode<int> node, bool isBoundary)
        {
            var result = new List<BinaryTreeNode<int>>();

            if (node != null)
            {
                result.AddRange(RightBoundaryAndLeaves(node.Left, isBoundary && node.Right == null));
                result.AddRange(RightBoundaryAndLeaves(node.Right, isBoundary));

                if (isBoundary && IsLeaf(node))
                {
                    result.Add(node);
                }
            }

            return result;
        }

        private bool IsLeaf(BinaryTreeNode<int> node)
        {
            return node.Left == null && node.Right == null;
        }
    }
}