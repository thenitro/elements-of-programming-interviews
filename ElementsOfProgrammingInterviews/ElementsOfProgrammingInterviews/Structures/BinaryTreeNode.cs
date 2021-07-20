namespace ElementsOfProgrammingInterviews.Structures
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode<T> Parent;
        public BinaryTreeNode<T> Left;
        public BinaryTreeNode<T> Right;
        public T Data;

        public BinaryTreeNode(T data)
        {
            Data = data;
        }
    }
}