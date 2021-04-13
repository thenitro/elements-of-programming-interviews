using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_10
    {
        public LinkedListNode Solution(LinkedListNode head)
        {
            var evenDummyHead = new LinkedListNode(-1);
            var oddDummyHead = new LinkedListNode(-1);

            var tails = new List<LinkedListNode>()
            {
                evenDummyHead,
                oddDummyHead
            };

            var turn = 0;

            for (var node = head; node != null; node = node.Next)
            {
                tails[turn].Next = node;
                tails[turn] = tails[turn].Next;
                turn ^= 1;
            }

            tails[1].Next = null;
            tails[0].Next = oddDummyHead.Next;

            return evenDummyHead.Next;
        }
    }
}