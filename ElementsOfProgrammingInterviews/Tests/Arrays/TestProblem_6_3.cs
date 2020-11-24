using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_3
    {
        [Test]
        public void Smoke()
        {
            var result = new Problem_6_3().Solution(new int[] {1, 2, 1}, new int[] {2, 3});

            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(7, result[1]);
            Assert.AreEqual(8, result[2]);
            Assert.AreEqual(3, result[3]);
        }
    }
}