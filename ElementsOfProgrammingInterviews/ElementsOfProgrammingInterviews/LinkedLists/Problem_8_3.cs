using System;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_3
    {
        public LinkedListNode Solution(LinkedListNode node)
        {
            var tortoise = node.Next;
            var hare = node.Next.Next;

            while (tortoise != hare)
            {
                tortoise = tortoise.Next;
                hare = hare.Next.Next;

                if (tortoise == null || hare == null)
                {
                    return null;
                }
            }
            
            hare = node;

            while (tortoise != hare)
            {
                hare = hare.Next;
                tortoise = tortoise.Next;
            }

            return hare;
        }
    }
}