namespace ElementsOfProgrammingInterviews.Structures
{
    public class HeapNode<T>
    {
        public double Priority;
        public T Data { get; }
        
        public HeapNode(double priority, T data)
        {
            Priority = priority;
            Data = data;
        }
    }
}