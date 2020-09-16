using ElementsOfProgrammingInterviews.HashTables;
using NUnit.Framework;

namespace Tests.HashTables
{
    [TestFixture]
    public class TestProblem_13_1
    {
        [Test]
        public void SmokeTest()
        {
            Assert.True(new Problem_13_1().Solution("level"));
            Assert.False(new Problem_13_1().Solution("lever"));
            Assert.True(new Problem_13_1().Solution("edified"));
        }
    }
}