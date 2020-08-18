using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_1
    {
        [Test]
        public void EdgeCases()
        {
            new Problem_6_1().Solution(null);

            var empty = new int[0];
            new Problem_6_1().Solution(empty);
            
            var one = new int[1] { 1 };
            new Problem_6_1().Solution(one);
            Assert.AreEqual(1, one[0]);
        }

        [Test]
        public void Smoke()
        {
            var smoke = new int[] {2, 1, 0, 0, 1, 2, 0, 0, 1, 2, 2, 0, 1};
            new Problem_6_1().Solution(smoke);
            
            Assert.AreEqual(0, smoke[0]);
            Assert.AreEqual(0, smoke[1]);
            Assert.AreEqual(0, smoke[2]);
            Assert.AreEqual(0, smoke[3]);
            Assert.AreEqual(0, smoke[4]);
            Assert.AreEqual(1, smoke[5]);
            Assert.AreEqual(1, smoke[6]);
            Assert.AreEqual(1, smoke[7]);
            Assert.AreEqual(1, smoke[8]);
            Assert.AreEqual(2, smoke[9]);
            Assert.AreEqual(2, smoke[10]);
            Assert.AreEqual(2, smoke[11]);
            Assert.AreEqual(2, smoke[12]);
        }
    }
}