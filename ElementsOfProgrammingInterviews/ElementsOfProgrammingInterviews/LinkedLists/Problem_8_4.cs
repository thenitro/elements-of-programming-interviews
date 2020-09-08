using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_4
    {
        public LinkedListNode Solution(LinkedListNode l1, LinkedListNode l2)
        {
            var l1Count = GetLength(l1);
            var l2Count = GetLength(l2);

            var bigger = l1Count > l2Count ? l1 : l2;
            var smaller = l1Count > l2Count ? l2 : l1;

            var diff = Math.Abs(l1Count - l2Count);
            
            while (bigger != null)
            {
                if (diff == 0)
                {
                    if (bigger == smaller)
                    {
                        return bigger;
                    }

                    smaller = smaller.Next;
                }
                else
                {
                    diff--;
                }

                bigger = bigger.Next;
            }

            return null;
        }

        private int GetLength(LinkedListNode node)
        {
            var result = 0;

            while (node != null)
            {
                result++;
                node = node.Next;
            }

            return result;
        }
    }
}