using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_3
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(4, new Problem_7_3().Solution("D"));
            Assert.AreEqual(27, new Problem_7_3().Solution("AA"));
            Assert.AreEqual(702, new Problem_7_3().Solution("ZZ"));
        }
    }
}