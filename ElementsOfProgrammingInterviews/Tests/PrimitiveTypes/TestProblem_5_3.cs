using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_5_3
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(3746994889972252672, new Problem_5_3().Solution(44));
        }
    }
}