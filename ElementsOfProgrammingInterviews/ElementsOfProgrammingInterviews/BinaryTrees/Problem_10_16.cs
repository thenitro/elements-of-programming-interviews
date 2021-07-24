using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_16
    {
        public void Solution(BinaryTreeNode<char> root)
        {
            var levels = new List<List<BinaryTreeNode<char>>>();

            var queue = new Queue<BinaryTreeNode<char>>();
                queue.Enqueue(root);
                
            var count = 1;

            var currentLevel = new List<BinaryTreeNode<char>>();

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                count--;
                currentLevel.Add(node);

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }

                if (count == 0)
                {
                    count = queue.Count;
                    levels.Add(currentLevel);
                    currentLevel = new List<BinaryTreeNode<char>>();
                }
            }

            foreach (var level in levels)
            {
                for (var i = 0; i < level.Count - 1; i++)
                {
                    level[i].RightSibling = level[i + 1];
                }
            }
        }
    }
}