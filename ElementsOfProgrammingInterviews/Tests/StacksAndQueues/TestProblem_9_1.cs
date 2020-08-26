using ElementsOfProgrammingInterviews.StacksAndQueues;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    [TestFixture]
    public class TestProblem_9_1
    {
        [Test]
        public void Smoke()
        {
            var stack = new Problem_9_1(10);

            Assert.AreEqual(int.MinValue, stack.Max);
            
            stack.Push(10);
            Assert.AreEqual(10, stack.Max);
            stack.Push(2);
            Assert.AreEqual(10, stack.Max);
            stack.Push(3);
            Assert.AreEqual(10, stack.Max);
            stack.Push(11);
            Assert.AreEqual(11, stack.Max);
            stack.Push(5);
            Assert.AreEqual(11, stack.Max);
            stack.Push(12);
            Assert.AreEqual(12, stack.Max);
            stack.Push(1);
            Assert.AreEqual(12, stack.Max);

            Assert.AreEqual(1, stack.Pop());
            Assert.AreEqual(12, stack.Max);
            Assert.AreEqual(12, stack.Pop());
            Assert.AreEqual(11, stack.Max);
            Assert.AreEqual(5, stack.Pop());
            Assert.AreEqual(11, stack.Max);
            Assert.AreEqual(11, stack.Pop());
            Assert.AreEqual(10, stack.Max);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(10, stack.Max);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(10, stack.Max);
            Assert.AreEqual(10, stack.Pop());
            Assert.AreEqual(int.MinValue, stack.Max);
        }
    }
}