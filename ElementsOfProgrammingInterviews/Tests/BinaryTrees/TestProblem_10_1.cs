using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_1
    {
        [Test]
        public void Smoke()
        {
            var root = new BinaryTreeNode<int>(2)
            {
                Left = new BinaryTreeNode<int>(1),
                Right = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(7),
                    Right = new BinaryTreeNode<int>(4)
                    {
                        Right = new BinaryTreeNode<int>(5)
                    }
                }
            };
            
            Assert.False(new Problem_10_1().Solution(root));
        }
    }
}