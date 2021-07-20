using ElementsOfProgrammingInterviews.StacksAndQueues;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    [TestFixture]
    public class TestProblem_9_7
    {
        [Test]
        public void Smoke()
        {
            var root = new BinaryTreeNode<int>(3)
            {
                Left = new BinaryTreeNode<int>(2)
                {
                    Left = new BinaryTreeNode<int>(1)
                },
                Right = new BinaryTreeNode<int>(6)
                {
                    Left = new BinaryTreeNode<int>(5)
                    {
                        Left = new BinaryTreeNode<int>(4)
                    },
                    Right = new BinaryTreeNode<int>(7)
                    {
                        Right = new BinaryTreeNode<int>(8)
                    }
                }
            };
            
            var result = new Problem_9_7().Solution(root);
            
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(3, result[0][0]);
            Assert.AreEqual(2, result[1][0]);
            Assert.AreEqual(6, result[1][1]);
            Assert.AreEqual(1, result[2][0]);
            Assert.AreEqual(5, result[2][1]);
            Assert.AreEqual(7, result[2][2]);
            Assert.AreEqual(4, result[3][0]);
            Assert.AreEqual(8, result[3][1]);
        }
    }
}