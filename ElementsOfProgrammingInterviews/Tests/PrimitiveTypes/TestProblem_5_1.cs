using System;
using ElementsOfProgrammingInterviews.PrimitiveTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_5_1
    {
        [Test]
        public void SmokeTest()
        {
            Assert.AreEqual(0, new Problem_5_1().Solution(0));//0
            Assert.AreEqual(1, new Problem_5_1().Solution(1));//1
            Assert.AreEqual(1, new Problem_5_1().Solution(2));//10
            Assert.AreEqual(0, new Problem_5_1().Solution(3));//11
            Assert.AreEqual(1, new Problem_5_1().Solution(4));//0100
            Assert.AreEqual(0, new Problem_5_1().Solution(5));//0101
            Assert.AreEqual(0, new Problem_5_1().Solution(6));//0110
            Assert.AreEqual(1, new Problem_5_1().Solution(7));//0111
        }
    }
}