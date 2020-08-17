using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_5_8
    {
        [Test]
        public void SmokeTest()
        {
            Assert.AreEqual(0, new Problem_5_8().Solution(0));
            Assert.AreEqual(1, new Problem_5_8().Solution(1));
            Assert.AreEqual(21, new Problem_5_8().Solution(12));
            Assert.AreEqual(123, new Problem_5_8().Solution(321));
            Assert.AreEqual(123, new Problem_5_8().Solution(321));
        }
    }
}