using ElementsOfProgrammingInterviews.Recursion;
using NUnit.Framework;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    [TestFixture]
    public class TestProblem_16_2
    {
        [Test]
        public void Smoke()
        {
            var result = new Problem_16_2().Solution(4);

            Assert.AreEqual(2, result.Count);
            
            Assert.AreEqual(1, result[0][0]);
            Assert.AreEqual(3, result[0][1]);
            Assert.AreEqual(0, result[0][2]);
            Assert.AreEqual(2, result[0][3]);
            
            Assert.AreEqual(2, result[1][0]);
            Assert.AreEqual(0, result[1][1]);
            Assert.AreEqual(3, result[1][2]);
            Assert.AreEqual(1, result[1][3]);
        }
    }
}