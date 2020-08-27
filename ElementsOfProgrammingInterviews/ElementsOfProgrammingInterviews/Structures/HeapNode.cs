namespace ElementsOfProgrammingInterviews.Structures
{
    public class HeapNode<T>
    {
        public int Priority;
        public T Data { get; }
        
        public HeapNode(int priority, T data)
        {
            Priority = priority;
            Data = data;
        }
    }
}