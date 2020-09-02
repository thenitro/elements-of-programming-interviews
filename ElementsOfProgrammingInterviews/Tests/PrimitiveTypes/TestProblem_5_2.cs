using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_5_2
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(11, new Problem_5_2().Solution(73, 6, 1));
            Assert.AreEqual(73, new Problem_5_2().Solution(73, 7, 1));
        }
    }
}