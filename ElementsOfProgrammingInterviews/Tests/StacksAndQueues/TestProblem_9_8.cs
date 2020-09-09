using ElementsOfProgrammingInterviews.StacksAndQueues;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    [TestFixture]
    public class TestProblem_9_8
    {
        [Test]
        public void SmokeTest()
        {
            var queue = new Problem_9_8(1);
            
            queue.Enqueue(1);
            
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(1, queue.Dequeue());
            
            queue.Enqueue(2);
            
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(1, queue.Dequeue());
        }
    }
}