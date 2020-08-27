using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_4
    {
        [Test]
        public void Smoke()
        {
            var root = new BinaryTreeNode(2);
            var left1 = new BinaryTreeNode(1)
            {
                Parent = root
            };
            
            var right1 = new BinaryTreeNode(3)
            {
                Parent = root
            };

            root.Left = left1;
            root.Right = right1;
            
            var right2 = new BinaryTreeNode(4)
            {
                Parent = right1
            };

            right1.Right = right2;
            
            var left3 = new BinaryTreeNode(6)
            {
                Parent = right2
            };
            
            var right3 = new BinaryTreeNode(5)
            {
                Parent = right2
            };

            right2.Left = left3;
            right2.Right = right3;
            
            var right4 = new BinaryTreeNode(7)
            {
                Parent = right3
            };

            right3.Right = right4;
            
            Assert.AreEqual(4, new Problem_10_4().Solution(left3, right4).Data);
        }
    }
}