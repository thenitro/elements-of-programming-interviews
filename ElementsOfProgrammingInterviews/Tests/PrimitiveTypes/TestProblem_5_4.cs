using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_5_4
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(5, new Problem_5_4().Solution(6));
        }
    }
}