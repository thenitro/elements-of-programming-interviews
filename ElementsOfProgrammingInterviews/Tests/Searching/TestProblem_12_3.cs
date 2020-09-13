using ElementsOfProgrammingInterviews.Searching;
using NUnit.Framework;

namespace Tests.Searching
{
    [TestFixture]
    public class TestProblem_12_3
    {
        [Test]
        public void Smoke()
        {
            var arr = new[] {378, 478, 550, 631, 103, 203, 220, 234, 279, 368};
            Assert.AreEqual(4, new Problem_12_3().Solution(arr));
        }
    }
}