namespace ElementsOfProgrammingInterviews.Structures
{
    public class LinkedListNode
    {
        public int Data;
        public LinkedListNode Next;
        public LinkedListNode Prev;
        public LinkedListNode Jump;
        public int Order = -1;

        public LinkedListNode(int data, LinkedListNode next = null)
        {
            Data = data;
            Next = next;
        }
    }
}