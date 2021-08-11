using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_14
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

            var node = new Problem_10_14().Solution(root);
            
            Assert.AreEqual(5, node.Data.Data);
            Assert.AreEqual(7, node.Next.Data.Data);
            Assert.AreEqual(6, node.Next.Next.Data.Data);
            Assert.AreEqual(10, node.Next.Next.Next.Data.Data);
            Assert.AreEqual(9, node.Next.Next.Next.Next.Data.Data);
        }
    }
}