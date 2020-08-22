using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    [TestFixture]
    public class TestProblem_7_2
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual("1A7", new Problem_7_2().Solution("615", 7, 13));
        }
    }
}