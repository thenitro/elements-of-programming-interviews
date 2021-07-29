using ElementsOfProgrammingInterviews.Heaps;
using NUnit.Framework;

namespace Tests.Heaps
{
    [TestFixture]
    public class TestProblem_11_5
    {
        [Test]
        public void Smoke()
        {
            var problem = new Problem_11_5();
            
            Assert.AreEqual(1, problem.Solution(1));
            Assert.AreEqual(0.5, problem.Solution(0));
            Assert.AreEqual(1, problem.Solution(3));
            Assert.AreEqual(2, problem.Solution(5));
            Assert.AreEqual(2, problem.Solution(2));
            Assert.AreEqual(1.5, problem.Solution(0));
            Assert.AreEqual(1, problem.Solution(1));
        }
    }
}