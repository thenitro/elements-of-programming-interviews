using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    public class TestProblem_6_6
    {
        [Test]
        public void Smoke()
        {
            Assert.AreEqual(30, new Problem_6_6().Solution(new [] { 310, 315, 275, 295, 260, 270, 290, 230, 255, 250 }));
            Assert.AreEqual(9, new Problem_6_6().Solution(new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }

        [Test]
        public void EdgeCases()
        {
            Assert.AreEqual(0, new Problem_6_6().Solution(null));
            Assert.AreEqual(0, new Problem_6_6().Solution(new int[0]));
            Assert.AreEqual(0, new Problem_6_6().Solution(new [] { 1 }));
        }
    }
}