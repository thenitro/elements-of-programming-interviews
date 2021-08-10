using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_6
    {
        [Test]
        public void Smoke()
        {
            var root = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(3)
                {
                    Left = new BinaryTreeNode<int>(5),
                    Right = new BinaryTreeNode<int>(4)
                    {
                        Right = new BinaryTreeNode<int>(6),
                        Left = new BinaryTreeNode<int>(7),
                    }
                },
                Right = new BinaryTreeNode<int>(8)
                {
                    Left = new BinaryTreeNode<int>(10),
                    Right = new BinaryTreeNode<int>(9)
                }
            };
            
            Assert.True(new Problem_10_6().Solution(root, 15));
        }
    }
}