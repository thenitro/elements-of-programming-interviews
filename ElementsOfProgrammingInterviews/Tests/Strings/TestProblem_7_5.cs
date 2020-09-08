using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    [TestFixture]
    public class TestProblem_7_5
    {
        [Test]
        public void Smoke()
        {
            Assert.True(new Problem_7_5().Solution("A man, a plan, a canal, Panama."));
            Assert.False(new Problem_7_5().Solution("Ray a ray!"));
        }
    }
}