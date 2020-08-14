using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_5_7
    {
        [Test]
        public void TestPositive()
        {
            Assert.AreEqual(1, new Problem_5_7().Solution(2.0, 0));
            Assert.AreEqual(2.0, new Problem_5_7().Solution(2.0, 1));
            Assert.AreEqual(4.0, new Problem_5_7().Solution(2.0, 2));
            Assert.AreEqual(8.0, new Problem_5_7().Solution(2.0, 3));
        }

        [Test]
        public void TestNegative()
        {
            Assert.AreEqual(0.5, new Problem_5_7().Solution(2.0, -1));
            Assert.AreEqual(0.25, new Problem_5_7().Solution(2.0, -2));
            Assert.AreEqual(0.125, new Problem_5_7().Solution(2.0, -3));
        }
    }
}