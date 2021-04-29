using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_13
    {
        public LinkedListNode Solution(LinkedListNode l1, LinkedListNode l2)
        {
            var head = new LinkedListNode(-1);

            var next1 = l1;
            var next2 = l2;

            var nextResult = head;

            var carry = 0;

            while (next1 != null && next2 != null)
            {
                var currentNumber = 
                    (next1 == null ? 0 : next1.Data) + 
                    (next2 == null ? 0 : next2.Data) + 
                    carry;
                
                if (currentNumber >= 10)
                {
                    carry = 1;
                    currentNumber -= 10;
                }
                else
                {
                    carry = 0;
                }

                nextResult.Next = new LinkedListNode(currentNumber);
                nextResult = nextResult.Next;

                next1 = next1 == null ? null : next1.Next;
                next2 = next2 == null ? null : next2.Next;
            }

            if (carry == 1)
            {
                nextResult.Next = new LinkedListNode(1);
            }
            
            return head.Next;
        }
    }
}