using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_9
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(59, new Problem_7_9().Solution("LIX"));
            Assert.AreEqual(59, new Problem_7_9().Solution("XXXXXIIIIIIIII"));
            Assert.AreEqual(59, new Problem_7_9().Solution("LVIIII"));
        }
    }
}