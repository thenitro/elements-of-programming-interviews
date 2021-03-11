using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_12
    {
        [Test]
        public void SmokeTest()
        {
            Assert.AreEqual("4a1b3c2a", new Problem_7_12().Encode("aaaabcccaa"));
            Assert.AreEqual("aaaabcccaa", new Problem_7_12().Decode("4a1b3c2a"));
        }
    }
}