using ElementsOfProgrammingInterviews.Searching;
using NUnit.Framework;

namespace Tests.Searching
{
    [TestFixture]
    public class TestProblem_12_5
    {
        [Test]
        public void SmokeTest()
        {
            Assert.AreEqual(4, new Problem_12_5().Solution(16));
        }
    }
}