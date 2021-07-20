using ElementsOfProgrammingInterviews.BinarySearchTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinarySearchTrees
{
    [TestFixture]
    public class TestProblem_15_2
    {
        [Test]
        public void Smoke()
        {
            var root = new BinaryTreeNode<int>(19)
            {
                Left = new BinaryTreeNode<int>(7)
                {
                    Left = new BinaryTreeNode<int>(3)
                    {
                        Left = new BinaryTreeNode<int>(2),
                        Right = new BinaryTreeNode<int>(5),
                    },
                    Right = new BinaryTreeNode<int>(11)
                    {
                        Right = new BinaryTreeNode<int>(17)
                        {
                            Left = new BinaryTreeNode<int>(13)
                        }
                    }
                },
                Right = new BinaryTreeNode<int>(43)
                {
                    Left = new BinaryTreeNode<int>(23)
                    {
                        Right = new BinaryTreeNode<int>(37)
                        {
                            Left = new BinaryTreeNode<int>(29)
                            {
                                Right = new BinaryTreeNode<int>(31)
                            },
                            Right = new BinaryTreeNode<int>(41)
                        }
                    },
                    Right = new BinaryTreeNode<int>(47)
                    {
                        Right = new BinaryTreeNode<int>(53)
                    }
                }
            };
            
            Assert.AreEqual(29, new Problem_15_2().Solution(root, 23).Data);
        }
    }
}