using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_18
    {
        [Test]
        public void Test2x2()
        {
            var matrix = new [,]
            {
                {1, 2},
                {3, 4},
            };
            
            new Problem_6_18().Solution(matrix);
            
            Assert.AreEqual(3, matrix[0, 0]);
            Assert.AreEqual(1, matrix[0, 1]);
            Assert.AreEqual(2, matrix[1, 1]);
            Assert.AreEqual(4, matrix[1, 0]);
        }
        
        [Test]
        public void Test3x3()
        {
            var matrix = new [,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };
            
            var expected = new [,]
            {
                {7, 4, 1},
                {8, 5, 2},
                {9, 6, 3},
            };
            
            new Problem_6_18().Solution(matrix);

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], matrix[i, j]);
                }
            }
        }
    }
}