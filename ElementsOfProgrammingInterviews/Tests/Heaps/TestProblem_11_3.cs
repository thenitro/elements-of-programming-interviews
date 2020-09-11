using ElementsOfProgrammingInterviews.Heaps;
using NUnit.Framework;

namespace Tests.Heaps
{
    [TestFixture]
    public class TestProblem_11_3
    {
        [Test]
        public void Smoke()
        {
            var array = new[] {3, -1, 2, 6, 4, 5, 8};
            
            new Problem_11_3().Solution(array, 2);
            
            Assert.AreEqual(-1, array[0]);
            Assert.AreEqual(2, array[1]);
            Assert.AreEqual(3, array[2]);
            Assert.AreEqual(4, array[3]);
            Assert.AreEqual(5, array[4]);
            Assert.AreEqual(6, array[5]);
            Assert.AreEqual(8, array[6]);
        }
    }
}