using ElementsOfProgrammingInterviews.DynamicProgramming;
using NUnit.Framework;

namespace Tests.DynamicProgramming
{
    [TestFixture]
    public class TestProblem_17_3
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(70, new Problem_17_3().Solution(5, 5));
        }
    }
}