namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_1
    {
        public LinkedListNode Solution(LinkedListNode l1, LinkedListNode l2)
        {
            LinkedListNode head = null;
            LinkedListNode node = new LinkedListNode(-1);

            while (l1 != null || l2 != null)
            {                
                if (l1 != null && (l2 == null || l1.Data < l2.Data))
                {
                    node.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    node.Next = l2;
                    l2 = l2.Next;
                }
                
                node = node.Next;
                
                if (head == null)
                {
                    head = node;
                }
            }

            return head;
        }
    }
}