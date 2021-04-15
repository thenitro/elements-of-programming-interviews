using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_11
    {
        public bool Solution(LinkedListNode head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            var firstHalf = head;
            var secondHalf = Reverse(slow);

            while (secondHalf != null && firstHalf != null)
            {
                if (secondHalf.Data != firstHalf.Data)
                {
                    return false;
                }
                
                secondHalf = secondHalf.Next;
                firstHalf = firstHalf.Next;
            }

            return true;
        }

        private LinkedListNode Reverse(LinkedListNode head)
        {
            var current = head;
            LinkedListNode prev = null;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;

                prev = current;
                current = next;
            }
            
            return prev;
        }
    }
}