using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_9
    {
        [Test]
        public void SmokeTest()
        {
            var result = new Problem_6_9().Solution(new[] {'a', 'b', 'c', 'd'}, new[] {2, 0, 1, 3});
            
            Assert.AreEqual('b',result[0]);
            Assert.AreEqual('c',result[1]);
            Assert.AreEqual('a',result[2]);
            Assert.AreEqual('d',result[3]);
        }
    }
}