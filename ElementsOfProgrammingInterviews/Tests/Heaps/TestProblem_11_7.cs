using ElementsOfProgrammingInterviews.Heaps;
using NUnit.Framework;

namespace Tests.Heaps
{
    [TestFixture]
    public class TestProblem_11_7
    {
        [Test]
        public void SmokeTest()
        {
            var stack = new Problem_11_7<int>();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }
    }
}