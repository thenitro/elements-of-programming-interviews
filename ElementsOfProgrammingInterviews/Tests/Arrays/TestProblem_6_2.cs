using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Arrays;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestProblem_6_2
    {
        [Test]
        public void Smoke()
        {
            var array = new Problem_6_2().Solution(new List<int>() {1, 2, 9});
            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(3, array[1]);
            Assert.AreEqual(0, array[2]);
            
            var array2 = new Problem_6_2().Solution(new List<int>() { 9, 9, 9});
            Assert.AreEqual(1, array2[0]);
            Assert.AreEqual(0, array2[1]);
            Assert.AreEqual(0, array2[2]);
            Assert.AreEqual(0, array2[3]);
        }
        
        [Test]
        public void Edge()
        {
            var array = new Problem_6_2().Solution(new List<int>());
            Assert.NotNull(array);
            
            var array2 = new Problem_6_2().Solution(null);
            Assert.Null(array2);
        }
    }
}