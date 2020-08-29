using ElementsOfProgrammingInterviews.Sorting;
using NUnit.Framework;

namespace Tests.Sorting
{
    [TestFixture]
    public class TestProblem_14_2
    {
        [Test]
        public void Smoke()
        {
            var a = new[] { 5, 13, 17, 0, 0, 0, 0, 0 };
            var b = new[] { 3, 7, 11, 19 };
            
            new Problem_14_2().Solution(a, b, 3, 4);
            
            Assert.AreEqual(3, a[0]);
            Assert.AreEqual(5, a[1]);
            Assert.AreEqual(7, a[2]);
            Assert.AreEqual(11, a[3]);
            Assert.AreEqual(13, a[4]);
            Assert.AreEqual(17, a[5]);
            Assert.AreEqual(19, a[6]);
            Assert.AreEqual(0, a[7]);
        }
    }
}