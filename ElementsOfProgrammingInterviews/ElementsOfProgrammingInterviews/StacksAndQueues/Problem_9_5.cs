using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_5
    {
        public void Solution(LinkedListNode head)
        {
            var stack = new Stack<LinkedListNode>();
            var order = 0;
            
            stack.Push(head);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (current != null && current.Order == -1)
                {
                    current.Order = order++;
                    
                    stack.Push(current.Next);
                    stack.Push(current.Jump);
                }
            }
        }
    }
}