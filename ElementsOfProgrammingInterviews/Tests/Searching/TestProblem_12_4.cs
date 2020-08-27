using ElementsOfProgrammingInterviews.Searching;
using NUnit.Framework;

namespace Tests.Searching
{
    [TestFixture]
    public class TestProblem_12_4
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(4, new Problem_12_4().Solution(16));
            Assert.AreEqual(4, new Problem_12_4().Solution(20));
            Assert.AreEqual(17, new Problem_12_4().Solution(300));
        }
    }
}