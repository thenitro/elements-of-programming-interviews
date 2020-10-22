using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_5_9
    {
        [Test]
        public void Smoke()
        {
            Assert.True(new Problem_5_9().Solution(121));
            Assert.True(new Problem_5_9().Solution(222));
            Assert.True(new Problem_5_9().Solution(0));
            Assert.False(new Problem_5_9().Solution(122));
            Assert.False(new Problem_5_9().Solution(-121));
        }
    }
}