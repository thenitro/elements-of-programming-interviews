using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_9
    {
        public LinkedListNode Solution(LinkedListNode head, int k)
        {
            var node = head;

            var newTail = head;
            var newHead = head;
            
            while (node != null)
            {
                if (k > 0)
                {
                    node = node.Next == null ? head : node.Next;
                    k--;
                }
                else
                {
                    node = node.Next;
                    
                    newTail = newHead;
                    newHead = newHead.Next;
                }
            }

            newTail.Next = null;

            node = newHead;

            while (node.Next != null)
            {
                node = node.Next;
            }

            node.Next = head;

            return newHead;
        }
    }
}