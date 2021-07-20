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
            var root = new BinaryTreeNode<int>(5)
            {
                Left = new BinaryTreeNode<int>(4)
                {
                    Left = new BinaryTreeNode<int>(2)
                    {
                        Left = new BinaryTreeNode<int>(1)
                    },
                    Right = new BinaryTreeNode<int>(5)
                },
                Right = new BinaryTreeNode<int>(6)
                {
                    Right = new BinaryTreeNode<int>(7)
                    {
                        Right = new BinaryTreeNode<int>(8)
                    }
                },
            };

            Assert.True(new Problem_15_1().Solution(root));
        }
        
        [Test]
        public void Wrong()
        {
            var root = new BinaryTreeNode<int>(5)
            {
                Left = new BinaryTreeNode<int>(4)
                {
                    Left = new BinaryTreeNode<int>(2)
                    {
                        Left = new BinaryTreeNode<int>(1)
                    },
                    Right = new BinaryTreeNode<int>(3)
                },
                Right = new BinaryTreeNode<int>(6)
                {
                    Right = new BinaryTreeNode<int>(7)
                    {
                        Right = new BinaryTreeNode<int>(8)
                    }
                },
            };
            
            var root2 = new BinaryTreeNode<int>(10)
            {
                Left = new BinaryTreeNode<int>(9)
                {
                    Left = new BinaryTreeNode<int>(8),
                    Right = new BinaryTreeNode<int>(12)
                },
                Right = new BinaryTreeNode<int>(11)
            };
            
            Assert.False(new Problem_15_1().Solution(root));
            Assert.False(new Problem_15_1().Solution(root2));
        }
    }
}