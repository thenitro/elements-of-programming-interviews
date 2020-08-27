namespace ElementsOfProgrammingInterviews.Structures
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode Parent;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;
        public int Data;

        public BinaryTreeNode(int data)
        {
            Data = data;
        }
    }
}