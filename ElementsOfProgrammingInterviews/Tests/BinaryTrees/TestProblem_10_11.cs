using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_11
    {
        [Test]
        public void Smoke()
        {
            var root = new BinaryTreeNode(2);

            var left = new BinaryTreeNode(1);
                left.Parent = root;
            
            var right = new BinaryTreeNode(4);
                right.Parent = root;

            root.Left = left;
            root.Right = right;
                
            var rightLeft = new BinaryTreeNode(3);
                rightLeft.Parent = right;
                
            var rightRight = new BinaryTreeNode(5);
                rightRight.Parent = right;

            right.Left = rightLeft;
            right.Right = rightRight;    

            var result = new Problem_10_11().Solution(root);
            
            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(5, result[4]);
        }
    }
}