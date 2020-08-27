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
            var root = new BinaryTreeNode(2)
            {
                Left = new BinaryTreeNode(1),
                Right = new BinaryTreeNode(3)
                {
                    Left = new BinaryTreeNode(7),
                    Right = new BinaryTreeNode(4)
                    {
                        Right = new BinaryTreeNode(5)
                    }
                }
            };
            
            Assert.False(new Problem_10_1().Solution(root));
        }
    }
}