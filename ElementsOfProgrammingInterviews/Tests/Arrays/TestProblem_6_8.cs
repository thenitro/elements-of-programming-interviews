using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_8
    {
        [Test]
        public void Smoke()
        {
            var result = new Problem_6_8().Solution(18);
            
            Assert.AreEqual(7, result.Count);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(5, result[2]);
            Assert.AreEqual(7, result[3]);
            Assert.AreEqual(11, result[4]);
            Assert.AreEqual(13, result[5]);
            Assert.AreEqual(17, result[6]);
        }
    }
}