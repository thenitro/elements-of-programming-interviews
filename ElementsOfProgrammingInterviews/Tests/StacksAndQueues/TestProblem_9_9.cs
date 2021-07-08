using ElementsOfProgrammingInterviews.StacksAndQueues;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    public class TestProblem_9_9
    {
        [Test]
        public void Smoke()
        {
            var queue = new Problem_9_9();
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            
            queue.Enqueue(3);
            
            Assert.AreEqual(3, queue.Dequeue());
        }
    }
}