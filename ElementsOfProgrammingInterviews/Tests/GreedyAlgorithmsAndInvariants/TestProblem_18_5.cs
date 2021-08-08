using ElementsOfProgrammingInterviews.GreedyAlgorithmsAndInvariants;
using NUnit.Framework;

namespace Tests.GreedyAlgorithmsAndInvariants
{
    [TestFixture]
    public class TestProblem_18_5
    {
        [Test]
        public void SmokeTest()
        {
            var array = new[] { "b", "a", "c", "a", "a", "b", "a", "a", "c", "a" };
            var result = new Problem_18_5().Solution(array);
            Assert.AreEqual("a", result);
        }
    }
}