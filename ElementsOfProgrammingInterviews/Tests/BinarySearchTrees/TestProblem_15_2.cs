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
            var root = new BinaryTreeNode(19)
            {
                Left = new BinaryTreeNode(7)
                {
                    Left = new BinaryTreeNode(3)
                    {
                        Left = new BinaryTreeNode(2),
                        Right = new BinaryTreeNode(5),
                    },
                    Right = new BinaryTreeNode(11)
                    {
                        Right = new BinaryTreeNode(17)
                        {
                            Left = new BinaryTreeNode(13)
                        }
                    }
                },
                Right = new BinaryTreeNode(43)
                {
                    Left = new BinaryTreeNode(23)
                    {
                        Right = new BinaryTreeNode(37)
                        {
                            Left = new BinaryTreeNode(29)
                            {
                                Right = new BinaryTreeNode(31)
                            },
                            Right = new BinaryTreeNode(41)
                        }
                    },
                    Right = new BinaryTreeNode(47)
                    {
                        Right = new BinaryTreeNode(53)
                    }
                }
            };
            
            Assert.AreEqual(29, new Problem_15_2().Solution(root, 23).Data);
        }
    }
}