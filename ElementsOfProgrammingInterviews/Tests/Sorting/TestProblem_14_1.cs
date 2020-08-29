using ElementsOfProgrammingInterviews.Sorting;
using NUnit.Framework;

namespace Tests.Sorting
{
    [TestFixture]
    public class TestProblem_14_1
    {
        [Test]
        public void Smoke()
        {
            var result = new Problem_14_1().Solution(
                new[] {2, 3, 3, 5, 5, 6, 7, 7, 8, 12},
                new[] {5, 5, 6, 8, 8, 9, 10, 10});
            
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(6, result[1]);
            Assert.AreEqual(8, result[2]);
        }
    }
}