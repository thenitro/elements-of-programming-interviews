using ElementsOfProgrammingInterviews.StacksAndQueues;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    public class TestProblem_9_4
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(
                "/usr/bin/gcc", 
                new Problem_9_4().Solution("/usr/lib/../bin/gcc"));
            
            Assert.AreEqual(
                "/scripts/awkscripts", 
                new Problem_9_4().Solution("/scripts//./../scripts/awkscripts/././"));
        }
    }
}