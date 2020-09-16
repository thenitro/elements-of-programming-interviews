using System;
using ElementsOfProgrammingInterviews.Sorting;
using NUnit.Framework;

namespace Tests.Sorting
{
    [TestFixture]
    public class TestProblem_14_4
    {
        [Test]
        public void Smoke()
        {
            var schedule = new Tuple<int, int>[]
            {
                new Tuple<int, int>(4, 5),
                new Tuple<int, int>(9, 17),
                new Tuple<int, int>(2, 7),
                new Tuple<int, int>(8, 9),
                new Tuple<int, int>(12, 15),
                new Tuple<int, int>(1, 5),
                new Tuple<int, int>(6, 10),
                new Tuple<int, int>(11, 13),
                new Tuple<int, int>(14, 15),
            };
            
            Assert.AreEqual(3, new Problem_14_4().Solution(schedule));
        }
    }
}