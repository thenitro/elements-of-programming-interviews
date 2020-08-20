using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_17
    {
        [Test]
        public void Smoke4x4()
        {
            var matrix = new int[,]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 },
            };

            var result = new Problem_6_17().Solution(matrix);
            
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(8, result[4]);
            Assert.AreEqual(12, result[5]);
            Assert.AreEqual(16, result[6]);
            Assert.AreEqual(15, result[7]);
            Assert.AreEqual(14, result[8]);
            Assert.AreEqual(13, result[9]);
            Assert.AreEqual(9, result[10]);
            Assert.AreEqual(5, result[11]);
            Assert.AreEqual(6, result[12]);
            Assert.AreEqual(7, result[13]);
            Assert.AreEqual(11, result[14]);
            Assert.AreEqual(10, result[15]);
        }
        
        [Test]
        public void Smoke3x3()
        {
            var matrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            var result = new Problem_6_17().Solution(matrix);
            
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(6, result[3]);
            Assert.AreEqual(9, result[4]);
            Assert.AreEqual(8, result[5]);
            Assert.AreEqual(7, result[6]);
            Assert.AreEqual(4, result[7]);
            Assert.AreEqual(5, result[8]);
        }
        
        [Test]
        public void Smoke2x2()
        {
            var matrix = new int[,]
            {
                { 1, 2 },
                { 3, 4 },
            };

            var result = new Problem_6_17().Solution(matrix);
            
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(4, result[2]);
            Assert.AreEqual(3, result[3]);
        }
        
        [Test]
        public void Edge()
        {
            var matrix = new int[,]
            {
                { 1 },
            };

            var result = new Problem_6_17().Solution(matrix);
            
            Assert.AreEqual(1, result[0]);
        }
    }
}