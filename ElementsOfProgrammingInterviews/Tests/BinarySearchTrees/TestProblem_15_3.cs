using ElementsOfProgrammingInterviews.BinarySearchTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinarySearchTrees
{
    [TestFixture]
    public class TestProblem_15_3
    {
        [Test]
        public void Smoke()
        {
            var tree = new BinaryTreeNode<int>(108)
            {
                Left = new BinaryTreeNode<int>(108)
                {
                    Left = new BinaryTreeNode<int>(-10)
                    {
                        Left = new BinaryTreeNode<int>(-14),
                        Right = new BinaryTreeNode<int>(2)
                    },
                    Right = new BinaryTreeNode<int>(108)
                },
                Right = new BinaryTreeNode<int>(285)
                {
                    Left = new BinaryTreeNode<int>(243),
                    Right = new BinaryTreeNode<int>(285)
                    {
                        Right = new BinaryTreeNode<int>(401)
                    }
                }
            };

            var list = new Problem_15_3().Solution(tree, 3);
            Assert.AreEqual(401, list[0].Data);
            Assert.AreEqual(285, list[1].Data);
            Assert.AreEqual(285, list[2].Data);
        }
    }
}