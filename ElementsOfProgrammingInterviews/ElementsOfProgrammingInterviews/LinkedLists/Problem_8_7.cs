using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_7
    {
        public LinkedListNode Solution(LinkedListNode head, int k)
        {
            var node = head;
            var remove = head;
            
            while (node != null)
            {
                if (k < 0)
                {
                    remove = remove.Next;
                }
                else
                {
                    k--;
                }

                node = node.Next;
            }
            
            remove.Next = remove.Next.Next;

            return head;
        }
    }
}