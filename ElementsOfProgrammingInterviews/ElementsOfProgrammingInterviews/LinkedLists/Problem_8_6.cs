using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_6
    {
        public void Solution(LinkedListNode node)
        {
            node.Data = node.Next.Data;
            node.Next = node.Next.Next;
        }
    }
}