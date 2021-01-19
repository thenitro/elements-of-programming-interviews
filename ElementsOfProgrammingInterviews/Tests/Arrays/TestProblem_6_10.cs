using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_10
    {
        [Test]
        public void Smoke()
        {
            var result = new Problem_6_10().Solution(new[] {6, 2, 1, 5, 4, 3, 0});
            
            Assert.AreEqual(6, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(0, result[3]);
            Assert.AreEqual(1, result[4]);
            Assert.AreEqual(4, result[5]);
            Assert.AreEqual(5, result[6]);
        }
    }
}