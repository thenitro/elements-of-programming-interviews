using ElementsOfProgrammingInterviews.StacksAndQueues;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    public class TestProblem_9_3
    {
        [Test]
        public void TestCorrect()
        {
            var problem = new Problem_9_3();
            
            Assert.True(problem.Solution("{}()[]"));
            Assert.True(problem.Solution("([]){()}"));
            Assert.True(problem.Solution("[()[]{()()}]"));
        }

        [Test]
        public void TestIncorrect()
        {
            var problem = new Problem_9_3();
            
            Assert.False(problem.Solution("{)"));
            Assert.False(problem.Solution("[()[]{()()"));
        }
    }
}