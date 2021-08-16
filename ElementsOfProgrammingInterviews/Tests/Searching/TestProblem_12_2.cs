using ElementsOfProgrammingInterviews.Searching;
using NUnit.Framework;

namespace Tests.Searching
{
    [TestFixture]
    public class TestProblem_12_2
    {
        [Test]
        public void Smoke()
        {
            var input = new int[] { -2, 0, 2, 3, 6, 7, 9 };
            
            Assert.AreEqual(3, new Problem_12_2().Solution(input));
        }
    }
}