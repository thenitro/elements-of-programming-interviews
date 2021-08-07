using ElementsOfProgrammingInterviews.DynamicProgramming;
using NUnit.Framework;

namespace Tests.DynamicProgramming
{
    [TestFixture]
    public class TestProblem_17_2
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(1, new Problem_17_2().Solution("hello", "hallo"));
        }
    }
}