using ElementsOfProgrammingInterviews.Heaps;
using NUnit.Framework;

namespace Tests.Heaps
{
    [TestFixture]
    public class TestProblem_11_4
    {
        [Test]
        public void Smoke()
        {
            var problem = new Problem_11_4(3);
            
            var planet1 = new Planet(1, 1, 1);
            var planet2 = new Planet(2, 2, 2);
            var planet3 = new Planet(3, 3, 3);
            var planet4 = new Planet(4, 4, 4);
            var planet5 = new Planet(5, 5, 5);
            var planet6 = new Planet(6, 6, 6);
            var planet7 = new Planet(7, 7, 7);
            var planet8 = new Planet(8, 8, 8);
            var planet9 = new Planet(9, 9, 9);

            var result = problem.SolutionStream(planet9);
            Assert.AreEqual(planet9, result[0]);
            
            result = problem.SolutionStream(planet8);
            Assert.AreEqual(planet9, result[0]);
            Assert.AreEqual(planet8, result[1]);
            
            result = problem.SolutionStream(planet7);
            Assert.AreEqual(planet9, result[0]);
            Assert.AreEqual(planet8, result[1]);
            Assert.AreEqual(planet7, result[2]);
            
            result = problem.SolutionStream(planet6);
            Assert.AreEqual(planet8, result[0]);
            Assert.AreEqual(planet7, result[1]);
            Assert.AreEqual(planet6, result[2]);
            
            result = problem.SolutionStream(planet5);
            Assert.AreEqual(planet7, result[0]);
            Assert.AreEqual(planet6, result[1]);
            Assert.AreEqual(planet5, result[2]);
            
            result = problem.SolutionStream(planet4);
            Assert.AreEqual(planet6, result[0]);
            Assert.AreEqual(planet5, result[1]);
            Assert.AreEqual(planet4, result[2]);
            
            result = problem.SolutionStream(planet3);
            Assert.AreEqual(planet5, result[0]);
            Assert.AreEqual(planet4, result[1]);
            Assert.AreEqual(planet3, result[2]);
            
            result = problem.SolutionStream(planet2);
            Assert.AreEqual(planet4, result[0]);
            Assert.AreEqual(planet3, result[1]);
            Assert.AreEqual(planet2, result[2]);
            
            result = problem.SolutionStream(planet1);
            Assert.AreEqual(planet3, result[0]);
            Assert.AreEqual(planet2, result[1]);
            Assert.AreEqual(planet1, result[2]);
        }
    }
}