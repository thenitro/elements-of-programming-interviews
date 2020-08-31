using System;
using ElementsOfProgrammingInterviews.Graphs;
using NUnit.Framework;

namespace Tests.Graphs
{
    [TestFixture]
    public class TestProblem_19_1
    {
        [Test]
        public void Smoke()
        {
            var maze = new int[,]
            {
                { 0, 1, 1, 1, 1, 1, 0, 0, 1, 1 },
                { 1, 1, 0, 1, 1, 1, 1, 1, 1, 1 },
                { 0, 1, 0, 1, 1, 0, 0, 1, 0, 0 },
                { 1, 1, 1, 0, 0, 0, 1, 1, 0, 1 },
                { 1, 0, 0, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 0, 1, 1, 0, 1, 0, 0, 1 },
                { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 1, 1 },
                { 0, 1, 0, 0, 1, 1, 1, 0, 0, 0 },
                { 1, 1, 1, 1, 1, 1, 1, 0, 0, 1 },
            };

            var path = new Problem_19_1().Solution(maze, new Tuple<int, int>(0, 9), new Tuple<int, int>(9, 0));
            
            Assert.NotNull(path);
        }
    }
}