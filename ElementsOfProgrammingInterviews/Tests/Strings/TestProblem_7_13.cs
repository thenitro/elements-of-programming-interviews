using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_13
    {
        [Test]
        public void SmokeTest()
        {
            Assert.AreEqual(10, new Problem_7_13().Solution("supernoisytextfortest", "text"));
        }
    }
}