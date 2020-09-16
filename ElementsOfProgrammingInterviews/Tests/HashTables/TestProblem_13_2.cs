using ElementsOfProgrammingInterviews.HashTables;
using NUnit.Framework;

namespace Tests.HashTables
{
    [TestFixture]
    public class TestProblem_13_2
    {
        [Test]
        public void Smoke()
        {
            Assert.False(new Problem_13_2().Solution("hello", "aloha"));
            Assert.False(new Problem_13_2().Solution("aloha", "hello"));
            Assert.True(new Problem_13_2().Solution("hello", "hell o mine"));
            Assert.False(new Problem_13_2().Solution("hell o mine", "hello"));
        }
    }
}