using ElementsOfProgrammingInterviews.StacksAndQueues;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    [TestFixture]
    public class TestProblem_9_2
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(15, new Problem_9_2().Solution("3,4,+,2,*,1,+"));
        }
    }
}