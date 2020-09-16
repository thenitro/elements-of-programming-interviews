using ElementsOfProgrammingInterviews.HashTables;
using NUnit.Framework;

namespace Tests.HashTables
{
    [TestFixture]
    public class TestProblem_13_6
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(2, 
                new Problem_13_6().Solution(
                    new []{ "All", "work", "and", "no", "play", "makes", "for", "no", "work", "no", "fun", "and", "no", "results" }));
        }
    }
}