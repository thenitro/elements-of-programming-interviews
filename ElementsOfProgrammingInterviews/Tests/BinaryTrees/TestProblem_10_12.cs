using ElementsOfProgrammingInterviews.BinaryTrees;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_12
    {
        [Test]
        public void Smoke()
        {
            var root = new Problem_10_12().Solution(
                new[] {2, 1, 3, 4, 5, 6, 7, 8, 9},
                new[] {3, 1, 5, 4, 2, 6, 7, 9, 8});
            
            Assert.AreEqual(2, root.Data);
            Assert.AreEqual(1, root.Left.Data);
            Assert.AreEqual(3, root.Left.Left.Data);
            Assert.AreEqual(4, root.Left.Right.Data);
            Assert.AreEqual(5, root.Left.Right.Left.Data);
            Assert.AreEqual(6, root.Right.Data);
            Assert.AreEqual(7, root.Right.Right.Data);
            Assert.AreEqual(8, root.Right.Right.Right.Data);
            Assert.AreEqual(9, root.Right.Right.Right.Left.Data);
        }
    }
}