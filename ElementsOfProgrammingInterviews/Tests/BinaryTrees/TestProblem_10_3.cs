using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_3
    {
        [Test]
        public void Smoke()
        {
            var nodeA = new BinaryTreeNode<int>(5);
            var nodeB = new BinaryTreeNode<int>(7);

            var root = new BinaryTreeNode<int>(1)
            {
                Left = new BinaryTreeNode<int>(3)
                {
                    Left = nodeA,
                    Right = new BinaryTreeNode<int>(4)
                    {
                        Right = new BinaryTreeNode<int>(6),
                        Left = nodeB,
                    }
                },
                Right = new BinaryTreeNode<int>(8)
                {
                    Left = new BinaryTreeNode<int>(10),
                    Right = new BinaryTreeNode<int>(9)
                }
            };

            var result = new Problem_10_3().Solution(root, nodeA, nodeB);
            
            Assert.NotNull(result);
            Assert.AreEqual(3, result.Data);
        }
    }
}