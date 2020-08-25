namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class LinkedListNode
    {
        public int Data;
        public LinkedListNode Next;

        public LinkedListNode(int data, LinkedListNode next = null)
        {
            Data = data;
            Next = next;
        }
    }
}