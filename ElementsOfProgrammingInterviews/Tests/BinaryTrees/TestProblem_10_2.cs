using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_2
    {
        [Test]
        public void Smoke()
        {
            var root = new BinaryTreeNode<int>(314)
            {
                Left = new BinaryTreeNode<int>(6)
                {
                    Right = new BinaryTreeNode<int>(2)
                    {
                        Right = new BinaryTreeNode<int>(3)
                    }
                },
                Right = new BinaryTreeNode<int>(6)
                {
                    Left = new BinaryTreeNode<int>(2)
                    {
                        Left = new BinaryTreeNode<int>(3)
                    }
                }
            };
            
            Assert.True(new Problem_10_2().Solution(root));
        }
        
        [Test]
        public void Negative()
        {
            var root = new BinaryTreeNode<int>(314)
            {
                Left = new BinaryTreeNode<int>(6)
                {
                    Right = new BinaryTreeNode<int>(2)
                },
                Right = new BinaryTreeNode<int>(6)
                {
                    Left = new BinaryTreeNode<int>(2)
                    {
                        Left = new BinaryTreeNode<int>(3)
                    }
                }
            };
            
            Assert.False(new Problem_10_2().Solution(root));
        }
    }
}