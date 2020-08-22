using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    [TestFixture]
    public class TestProblem_7_4
    {
        [Test]
        public void Smoke()
        {
            var chars = new[] {'a', 'c', 'd', 'b', 'b', 'c', 'a'};
            new Problem_7_4().Solution(chars, 4);
            
            Assert.AreEqual('d', chars[0]);
            Assert.AreEqual('d', chars[1]);
            Assert.AreEqual('c', chars[2]);
            Assert.AreEqual('d', chars[3]);
            Assert.AreEqual('c', chars[4]);
            Assert.AreEqual('d', chars[5]);
            Assert.AreEqual('d', chars[6]);
        }
    }
}