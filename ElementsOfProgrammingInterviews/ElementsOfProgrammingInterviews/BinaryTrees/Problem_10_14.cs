using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_14
    {
        public LinkedListNode Solution(BinaryTreeNode<int> root)
        {
            var queue = new Stack<BinaryTreeNode<int>>();
                queue.Push(root);

            var current = root;
            
            var head = new LinkedListNode(null);
            var node = head;

            while (queue.Count > 0 || current != null)
            {
                if (current != null)
                {
                    queue.Push(current);
                    current = current.Left;
                }
                else
                {
                    current = queue.Pop();

                    if (current.Left == null && current.Right == null)
                    {
                        node.Next = new LinkedListNode(current);
                        node = node.Next;
                    }
                    
                    current = current.Right;
                }
            }

            return head.Next;
        }
    }
    
    public class LinkedListNode
    {
        public BinaryTreeNode<int> Data;
        public LinkedListNode Next;
        public LinkedListNode Prev;
        public LinkedListNode Jump;
        public int Order = -1;

        public LinkedListNode(BinaryTreeNode<int> data, LinkedListNode next = null)
        {
            Data = data;
            Next = next;
        }
    }
}