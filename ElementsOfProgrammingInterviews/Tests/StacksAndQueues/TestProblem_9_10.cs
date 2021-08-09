using ElementsOfProgrammingInterviews.StacksAndQueues;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    [TestFixture]
    public class TestProblem_9_10
    {
        [Test]
        public void Smoke()
        {
            var problem = new Problem_9_10(3);
            
            problem.Enqueue(5);
            Assert.AreEqual(5, problem.Peek());
            Assert.AreEqual(5, problem.Max());
            
            problem.Enqueue(3);
            Assert.AreEqual(3, problem.Peek());
            Assert.AreEqual(5, problem.Max());
            
            problem.Enqueue(8);
            Assert.AreEqual(8, problem.Peek());
            Assert.AreEqual(8, problem.Max());

            problem.Dequeue();
            Assert.AreEqual(3, problem.Peek());
            Assert.AreEqual(5, problem.Max());

            problem.Dequeue();
            Assert.AreEqual(5, problem.Peek());
            Assert.AreEqual(5, problem.Max());
        }
    }
}