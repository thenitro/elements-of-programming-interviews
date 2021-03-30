using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_8
    {
        public void Solution(LinkedListNode head)
        {
            var node = head;

            while (node != null && node.Next != null)
            {
                if (node.Data == node.Next.Data)
                {
                    node.Next = node.Next.Next;
                }

                node = node.Next;
            }
        }
    }
}