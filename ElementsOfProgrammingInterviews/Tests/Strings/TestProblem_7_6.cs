using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    [TestFixture]
    public class TestProblem_7_6
    {
        [Test]
        public void Smoke()
        {
            var s = "Alice likes Bob".ToCharArray();
            new Problem_7_6().Solution(s);
            
            Assert.AreEqual("Bob likes Alice", new string(s));
        }
    }
}