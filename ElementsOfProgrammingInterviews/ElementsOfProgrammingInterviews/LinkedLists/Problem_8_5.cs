using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_5
    {
        public LinkedListNode Solution(LinkedListNode L1, LinkedListNode L2)
        {
            var root1 = HasCycle(L1);
            var root2 = HasCycle(L2);

            if (root1 == null && root2 == null)
            {
                return OverlappingNoCycle(L1, L2);
            }
            else if ((root1 != null && root2 == null) || (root1 == null && root2 != null))
            {
                return null;
            }

            var temp = root2;

            do
            {
                temp = temp.Next;
            } while (temp != root1 && temp != root2);

            if (temp != root1)
            {
                return null;
            }

            var distance1 = Distance(L1, root1);
            var distance2 = Distance(L2, root2);

            var k = Math.Abs(distance1 - distance2);
            
            if (distance1 > distance2)
            {
                L1 = AdvanceListByK(L1, k);
            }
            else
            {
                L2 = AdvanceListByK(L2, k);
            }

            while (L1 != L2 && L1 != root1 && L2 != root2)
            {
                L1 = L1.Next;
                L2 = L2.Next;
            }

            return L1 == L2 ? L1 : root1;
        }

        private LinkedListNode HasCycle(LinkedListNode list)
        {
            var pointerSlow = list;
            var pointerFast = list;

            while (pointerSlow != null && pointerSlow.Next != null && pointerFast != null && pointerFast.Next.Next != null)
            {
                pointerSlow = pointerSlow.Next;
                pointerFast = pointerFast.Next.Next;

                if (pointerSlow == pointerFast)
                {
                    pointerSlow = list;

                    while (pointerSlow != pointerFast)
                    {
                        pointerFast = pointerFast.Next;
                    }

                    return pointerSlow;
                }
            }

            return null;
        }

        private LinkedListNode OverlappingNoCycle(LinkedListNode L1, LinkedListNode L2)
        {
            var l1Count = GetLength(L1);
            var l2Count = GetLength(L2);

            var bigger = l1Count > l2Count ? L1 : L2;
            var smaller = l1Count > l2Count ? L2 : L1;

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

        private int GetLength(LinkedListNode list)
        {
            var count = 0;

            while (list != null)
            {
                list = list.Next;
                count++;
            }

            return count;
        }

        private int Distance(LinkedListNode root, LinkedListNode target)
        {
            var count = 0;

            while (root != target)
            {
                root = root.Next;
                count++;
            }
            
            return count;
        }

        private LinkedListNode AdvanceListByK(LinkedListNode node, int k)
        {
            while (k > 0)
            {
                node = node.Next;
                k--;
            }

            return node;
        }
    }
}