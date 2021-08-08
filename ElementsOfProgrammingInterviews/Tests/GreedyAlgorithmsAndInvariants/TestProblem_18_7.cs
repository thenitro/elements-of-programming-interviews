using ElementsOfProgrammingInterviews.GreedyAlgorithmsAndInvariants;
using NUnit.Framework;

namespace Tests.GreedyAlgorithmsAndInvariants
{
    [TestFixture]
    public class TestProblem_18_7
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(48, new Problem_18_7().Solution(new []{ 1, 2, 1, 3, 4, 4, 5, 6, 2, 1, 3, 1, 3, 2, 1, 2, 4, 1 }));
        }
    }
}