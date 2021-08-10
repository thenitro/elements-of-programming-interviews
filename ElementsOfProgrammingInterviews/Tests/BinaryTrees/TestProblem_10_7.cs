using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_7
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

            var result = new Problem_10_7().Solution(root);
            Assert.AreEqual(9, result.Count);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(7, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(6, result[4]);
            Assert.AreEqual(1, result[5]);
            Assert.AreEqual(10, result[6]);
            Assert.AreEqual(8, result[7]);
            Assert.AreEqual(9, result[8]);
        }
    }
}