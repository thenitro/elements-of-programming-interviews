using ElementsOfProgrammingInterviews.Heaps;
using NUnit.Framework;

namespace Tests.Heaps
{
    [TestFixture]
    public class TestProblem_11_2
    {
        [Test]
        public void Smoke()
        {
            var input = new int[] { 57, 131, 493, 294, 221, 339, 418, 452, 442, 190 };

            var result = new Problem_11_2().Solution(input);
            
            Assert.AreEqual(10, result.Count);
            Assert.AreEqual(57, result[0]);
            Assert.AreEqual(131, result[1]);
            Assert.AreEqual(190, result[2]);
            Assert.AreEqual(221, result[3]);
            Assert.AreEqual(294, result[4]);
            Assert.AreEqual(339, result[5]);
            Assert.AreEqual(418, result[6]);
            Assert.AreEqual(442, result[7]);
            Assert.AreEqual(452, result[8]);
            Assert.AreEqual(493, result[9]);
        }
    }
}