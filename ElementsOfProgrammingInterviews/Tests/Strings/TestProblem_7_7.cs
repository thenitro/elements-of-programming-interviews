using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_7
    {
        [Test]
        public void SmokeTest()
        {
            var result = new Problem_7_7().Solution("2276696");

            Assert.AreEqual(3888, result.Count);
        }
    }
}