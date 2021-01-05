using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    public class TestProblem_6_4
    {
        [Test]
        public void Smoke()
        {
            Assert.True(new Problem_6_4().Solution(new [] { 3, 3, 1, 0, 2, 0, 1 }));
            Assert.False(new Problem_6_4().Solution(new [] { 3, 2, 0, 0, 2, 0, 1 }));
        }
    }
}