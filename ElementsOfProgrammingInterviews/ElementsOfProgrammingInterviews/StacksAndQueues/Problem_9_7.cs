using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_7
    {
        public List<List<int>> Solution(BinaryTreeNode<int> root)
        {
            var result = new List<List<int>>();
            var queue = new Queue<BinaryTreeNode<int>>();
                queue.Enqueue(root);
                
            var counter = 1;

            while (queue.Count > 0)
            {
                var subresult = new List<int>();
                
                for (var i = 0; i < counter; i++)
                {
                    var node = queue.Dequeue();
                    subresult.Add(node.Data);

                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                counter = queue.Count;
                result.Add(subresult);
            }

            return result;
        }
    }
}