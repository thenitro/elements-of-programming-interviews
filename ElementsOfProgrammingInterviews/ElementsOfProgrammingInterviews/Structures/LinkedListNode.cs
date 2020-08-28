namespace ElementsOfProgrammingInterviews.Structures
{
    public class LinkedListNode
    {
        public int Data;
        public LinkedListNode Next;
        public LinkedListNode Prev;

        public LinkedListNode(int data, LinkedListNode next = null)
        {
            Data = data;
            Next = next;
        }
    }
}