using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    public class TestProblem_6_19
    {
        [Test]
        public void SmokeTest()
        {
            var result = new Problem_6_19().Solution(5);
            
            Assert.AreEqual(5, result.Count);
            
            Assert.AreEqual(1, result[0].Length);
            Assert.AreEqual(1, result[0][0]);
            
            Assert.AreEqual(2, result[1].Length);
            Assert.AreEqual(1, result[1][0]);
            Assert.AreEqual(1, result[1][1]);

            Assert.AreEqual(3, result[2].Length);
            Assert.AreEqual(1, result[2][0]);
            Assert.AreEqual(2, result[2][1]);
            Assert.AreEqual(1, result[2][2]);

            Assert.AreEqual(4, result[3].Length);
            Assert.AreEqual(1, result[3][0]);
            Assert.AreEqual(3, result[3][1]);
            Assert.AreEqual(3, result[3][2]);
            Assert.AreEqual(1, result[3][3]);

            Assert.AreEqual(5, result[4].Length);
            Assert.AreEqual(1, result[4][0]);
            Assert.AreEqual(4, result[4][1]);
            Assert.AreEqual(6, result[4][2]);
            Assert.AreEqual(4, result[4][3]);
            Assert.AreEqual(1, result[4][4]);
        }
    }
}