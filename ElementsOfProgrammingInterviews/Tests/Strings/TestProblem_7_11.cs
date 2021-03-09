using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_11
    {
        [Test]
        public void SmokeTest()
        {
            Assert.AreEqual("e lHloWrdlo!", new Problem_7_11().Solution("Hello World!"));
        }
    }
}