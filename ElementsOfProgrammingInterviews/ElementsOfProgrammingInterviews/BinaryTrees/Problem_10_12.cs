using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_12
    {
        public BinaryTreeNode<int> Solution(int[] preorder, int[] inorder)
        {
            var inorderIndexes = new Dictionary<int, int>();
            for (var i = 0; i < inorder.Length; i++)
            {
                inorderIndexes[inorder[i]] = i;
            }
            
            return SolutionHelper(preorder, 0, preorder.Length, 0, inorder.Length, inorderIndexes);
        }

        private BinaryTreeNode<int> SolutionHelper(
            int[] preorder, 
            int preorderStart, int preorderEnd, 
            int inorderStart, int inorderEnd,
            Dictionary<int, int> inorderIndexes)
        {
            if (preorderStart >= preorderEnd || inorderStart >= inorderEnd)
            {
                return null;
            }

            var rootInorderIndex = inorderIndexes[preorder[preorderStart]];
            var leftSubtreeSize = rootInorderIndex - inorderStart;
            
            return new BinaryTreeNode<int>(preorder[preorderStart])
            {
                Left = SolutionHelper(preorder, preorderStart + 1, preorderStart + 1 + leftSubtreeSize, inorderStart, rootInorderIndex, inorderIndexes),
                Right = SolutionHelper(preorder, preorderStart + 1 + leftSubtreeSize, preorderEnd, rootInorderIndex + 1, inorderEnd, inorderIndexes),
            };
        }
    }
}