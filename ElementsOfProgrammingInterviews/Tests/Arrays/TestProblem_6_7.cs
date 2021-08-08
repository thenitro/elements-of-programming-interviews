using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_7
    {
        [Test]
        public void Smoke()
        {
            var input = new[] { 12, 11, 13, 9, 12, 8, 14, 13, 15 };
            
            Assert.AreEqual(10, new Problem_6_7().Solution(input));
        }
    }
}