using ElementsOfProgrammingInterviews.GreedyAlgorithmsAndInvariants;
using NUnit.Framework;

namespace Tests.GreedyAlgorithmsAndInvariants
{
    [TestFixture]
    public class TestProblem_18_4
    {
        [Test]
        public void Smoke() 
        {
            Assert.True(new Problem_18_4().Solution(new []{ 11, 2, 5, 7, 3 }, 21));
            Assert.False(new Problem_18_4().Solution(new []{ 11, 2, 5, 7, 3 }, 22));
        }
    }
}