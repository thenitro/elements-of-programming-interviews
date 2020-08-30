using ElementsOfProgrammingInterviews.DynamicProgramming;
using NUnit.Framework;

namespace Tests.DynamicProgramming
{
    [TestFixture]
    public class TestProblem_17_1
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(4, new Problem_17_1().Solution(new []{ 2, 3, 7 }, 12));
        }
    }
}