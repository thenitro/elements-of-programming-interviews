using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.BinaryTrees
{
    public class Problem_10_13
    {
        public BinaryTreeNode<string> Solution(string input)
        {
            var index = new int[1];
            var splitted = input.Split(',');
            
            return MakeTree(splitted, index);
        }

        private BinaryTreeNode<string> MakeTree(string[] input, int[] index)
        {
            var symbol = input[index[0]];
            index[0]++;
            
            if (symbol == "null")
            {
                return null;
            }

            return new BinaryTreeNode<string>(symbol)
            {
                Left = MakeTree(input, index),
                Right = MakeTree(input, index),
            };
        }
    }
}