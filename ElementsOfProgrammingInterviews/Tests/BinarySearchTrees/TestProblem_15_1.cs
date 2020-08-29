using ElementsOfProgrammingInterviews.BinarySearchTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinarySearchTrees
{
    [TestFixture]
    public class TestProblem_15_1
    {
        [Test]
        public void Smoke()
        {
            var root = new BinaryTreeNode(5)
            {
                Left = new BinaryTreeNode(4)
                {
                    Left = new BinaryTreeNode(2)
                    {
                        Left = new BinaryTreeNode(1)
                    },
                    Right = new BinaryTreeNode(5)
                },
                Right = new BinaryTreeNode(6)
                {
                    Right = new BinaryTreeNode(7)
                    {
                        Right = new BinaryTreeNode(8)
                    }
                },
            };
            
            Assert.True(new Problem_15_1().Solution(root));
        }
        
        [Test]
        public void Wrong()
        {
            var root = new BinaryTreeNode(5)
            {
                Left = new BinaryTreeNode(4)
                {
                    Left = new BinaryTreeNode(2)
                    {
                        Left = new BinaryTreeNode(1)
                    },
                    Right = new BinaryTreeNode(3)
                },
                Right = new BinaryTreeNode(6)
                {
                    Right = new BinaryTreeNode(7)
                    {
                        Right = new BinaryTreeNode(8)
                    }
                },
            };
            
            Assert.False(new Problem_15_1().Solution(root));
        }
    }
}