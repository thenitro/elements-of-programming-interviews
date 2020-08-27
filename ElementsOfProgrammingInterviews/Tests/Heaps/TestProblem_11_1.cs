using ElementsOfProgrammingInterviews.Heaps;
using NUnit.Framework;

namespace Tests.Heaps
{
    [TestFixture]
    public class TestProblem_11_1
    {
        [Test]
        public void Smoke()
        {
            var result = new Problem_11_1().Solution(
                new []
                {
                    new []{ 3, 5, 7 },
                    new []{ 0, 6 },
                    new []{ 0, 6, 28 },
                });
            
            Assert.NotNull(result);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(5, result[3]);
            Assert.AreEqual(6, result[4]);
            Assert.AreEqual(6, result[5]);
            Assert.AreEqual(7, result[6]);
            Assert.AreEqual(28, result[7]);
        }
    }
}