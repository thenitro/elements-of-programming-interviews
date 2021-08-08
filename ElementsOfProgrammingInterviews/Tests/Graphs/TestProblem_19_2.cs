using System;
using ElementsOfProgrammingInterviews.Graphs;
using NUnit.Framework;

namespace Tests.Graphs
{
    [TestFixture]
    public class TestProblem_19_2
    {
        [Test]
        public void Smoke()
        {
            var matrix = new []
            {
                new [] { 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, },
                new [] { 0, 0, 1, 0, 0, 1, 0, 0, 1, 1, },
                new [] { 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, },
                new [] { 0, 1, 0, 1, 1, 1, 1, 0, 1, 0, },
                new [] { 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, },
                new [] { 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, },
                new [] { 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, },
                new [] { 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, },
                new [] { 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, },
                new [] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, },
            };

            new Problem_19_2().Solution(5, 4, matrix);
            new Problem_19_2().Solution(3, 6, matrix);

            foreach (var i in matrix)
            {
                Console.WriteLine(string.Join("", i));
            }
        }
    }
}