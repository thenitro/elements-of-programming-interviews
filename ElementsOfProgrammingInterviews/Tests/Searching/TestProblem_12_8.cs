using ElementsOfProgrammingInterviews.Searching;
using NUnit.Framework;

namespace Tests.Searching
{
    [TestFixture]
    public class TestProblem_12_8
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(5, new Problem_12_8().Solution(1, new []{ 3, 2, 1, 5, 4 }));
            Assert.AreEqual(4, new Problem_12_8().Solution(2, new []{ 3, 2, 1, 5, 4 }));
            Assert.AreEqual(3, new Problem_12_8().Solution(3, new []{ 3, 2, 1, 5, 4 }));
            Assert.AreEqual(2, new Problem_12_8().Solution(4, new []{ 3, 2, 1, 5, 4 }));
            Assert.AreEqual(1, new Problem_12_8().Solution(5, new []{ 3, 2, 1, 5, 4 }));
        }
    }
}