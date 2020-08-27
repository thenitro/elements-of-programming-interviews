using ElementsOfProgrammingInterviews.Searching;
using NUnit.Framework;

namespace Tests.Searching
{
    [TestFixture]
    public class TestProblem_12_1
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(6, 
                new Problem_12_1().Solution(new []{ -14, -10, 2, 108, 108, 243, 285, 285, 285, 401 }, 285));
        }
    }
}