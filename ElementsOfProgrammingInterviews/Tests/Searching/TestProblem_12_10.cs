using ElementsOfProgrammingInterviews.Searching;
using NUnit.Framework;

namespace Tests.Searching
{
    public class TestProblem_12_10
    {
        [Test]
        public void Smoke()
        {
            var result = new Problem_12_10()
                .Solution(new[] { 5, 5, 0, 1, 3, 2 });
            
            Assert.AreEqual(5, result.Duplicate);
            Assert.AreEqual(4, result.Missing);
        }
    }
}