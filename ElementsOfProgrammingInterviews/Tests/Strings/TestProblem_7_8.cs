using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_8
    {
        [Test]
        public void SmokeTest()
        {
            var result = new Problem_7_8().Solution(8);
            
            Assert.AreEqual("1113213211", result);
        }
    }
}