using System;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_12
    {
        public LinkedListNode Solution(LinkedListNode node, int k)
        {
            LinkedListNode lessHead = null;
            LinkedListNode less = null;
            LinkedListNode equalsHead = null;
            LinkedListNode equals = null;
            LinkedListNode moreHead = null;
            LinkedListNode more = null;

            var current = node;

            while (current != null)
            {
                var next = current.Next;
                current.Next = null;
                
                if (current.Data < k)
                {
                    if (less == null)
                    {
                        less = current;
                        lessHead = less;
                    }
                    else
                    {
                        less.Next = current;
                        less = current;
                    }
                } 
                else if (current.Data == k)
                {
                    if (equals == null)
                    {
                        equals = current;
                        equalsHead = current;
                        
                        if (lessHead == null)
                        {
                            lessHead = equals;
                        }
                    }
                    else
                    {
                        equals.Next = current;
                        equals = current;
                    }
                }
                else
                {
                    if (more == null)
                    {
                        more = current;
                        moreHead = current;
                    }
                    else
                    {
                        more.Next = current;
                        more = current;
                    }
                }
                
                current = next;
            }
            
            if (less != null)
            {
                less.Next = equalsHead;
            }
            
            equals.Next = moreHead;
            
            return lessHead;
        }
    }
}