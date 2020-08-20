using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_11
    {
        [Test]
        public void SmokeTest()
        {
            Assert.AreEqual(5, new Problem_6_11().Solution(5, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).Length);
        }
        
        [Test]
        public void Edge()
        {
            Assert.AreEqual(0, new Problem_6_11().Solution(0, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }).Length);
            Assert.Null(new Problem_6_11().Solution(11, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
        }
    }
}