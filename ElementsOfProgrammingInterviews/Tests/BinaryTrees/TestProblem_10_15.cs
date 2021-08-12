using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_15
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
                        Left = new BinaryTreeNode<int>(7),
                        Right = new BinaryTreeNode<int>(6),
                    }
                },
                Right = new BinaryTreeNode<int>(8)
                {
                    Left = new BinaryTreeNode<int>(10),
                    Right = new BinaryTreeNode<int>(9)
                }
            };

            var results = new Problem_10_15().Solution(root);
            
            Assert.AreEqual(6, results.Count);
            Assert.AreEqual(1, results[0].Data);
            Assert.AreEqual(3, results[1].Data);
            Assert.AreEqual(5, results[2].Data);
            Assert.AreEqual(7, results[3].Data);
            Assert.AreEqual(6, results[4].Data);
            Assert.AreEqual(9, results[5].Data);
        }
    }
}