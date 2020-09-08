using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_5
    {
        [Test]
        public void Smoke()
        {
            var array = new[] {2, 3, 5, 5, 7, 11, 11, 11, 13};

            Assert.AreEqual(6, new Problem_6_5().Solution(array));
            
            Assert.AreEqual(2, array[0]);
            Assert.AreEqual(3, array[1]);
            Assert.AreEqual(5, array[2]);
            Assert.AreEqual(7, array[3]);
            Assert.AreEqual(11, array[4]);
            Assert.AreEqual(13, array[5]);
        }
    }
}