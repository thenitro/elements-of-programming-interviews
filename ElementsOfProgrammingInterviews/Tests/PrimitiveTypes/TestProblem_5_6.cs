using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_5_6
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(2, new Problem_5_6().Solution(4, 2));
            Assert.AreEqual(2, new Problem_5_6().Solution(-4, -2));
            Assert.AreEqual(-2, new Problem_5_6().Solution(-4, 2));
            Assert.AreEqual(-2, new Problem_5_6().Solution(4, -2));
        }
    }
}