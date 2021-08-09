using ElementsOfProgrammingInterviews.StacksAndQueues;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    [TestFixture]
    public class TestProblem_9_6
    {
        [Test]
        public void Smoke()
        {
            var buildings = new[] { 8, 7, 1, 2, 4, 6, 3, 2, 1, 5 };

            var result = new Problem_9_6().Solution(buildings);
            
            Assert.AreEqual(4, result.Length);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(6, result[1]);
            Assert.AreEqual(7, result[2]);
            Assert.AreEqual(8, result[3]);
        }
    }
}