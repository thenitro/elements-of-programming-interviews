using ElementsOfProgrammingInterviews.GreedyAlgorithmsAndInvariants;
using NUnit.Framework;

namespace Tests.GreedyAlgorithmsAndInvariants
{
    [TestFixture]
    public class TestProblem_18_6
    {
        [Test]
        public void Smoke()
        {
            var result = new Problem_18_6().Solution(
                new[] { 50, 20, 5, 30, 25, 10, 10 },
                new[] { 900, 600, 200, 400, 600, 200, 100 });

            Assert.AreEqual(3, result);
        }
    }
}