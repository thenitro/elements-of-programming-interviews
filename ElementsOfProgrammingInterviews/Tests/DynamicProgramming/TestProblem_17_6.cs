using System;
using System.Collections.Generic;
using ElementsOfProgrammingInterviews.DynamicProgramming;
using NUnit.Framework;

namespace Tests.DynamicProgramming
{
    [TestFixture]
    public class TestProblem_17_6
    {
        [Test]
        public void Smoke()
        {
            var clocks = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(65, 20),
                new Tuple<int, int>(35, 8),
                new Tuple<int, int>(245, 60),
                new Tuple<int, int>(195, 55),
                new Tuple<int, int>(165, 40),
                new Tuple<int, int>(150, 70),
                new Tuple<int, int>(275, 85),
                new Tuple<int, int>(155, 25),
                new Tuple<int, int>(120, 30),
                new Tuple<int, int>(320, 65),
                new Tuple<int, int>(75, 75),
                new Tuple<int, int>(40, 10),
                new Tuple<int, int>(200, 95),
                new Tuple<int, int>(100, 50),
                new Tuple<int, int>(220, 40),
                new Tuple<int, int>(99, 10),
            };
            
            Assert.AreEqual(695, new Problem_17_6().Solution(clocks, 130));
        }
    }
}