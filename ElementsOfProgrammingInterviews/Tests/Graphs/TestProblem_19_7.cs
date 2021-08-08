using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Graphs;
using NUnit.Framework;

namespace Tests.Graphs
{
    [TestFixture]
    public class TestProblem_19_7
    {
        [Test]
        public void Smoke()
        {
            var dict = new HashSet<string>()
            {
                "bat",
                "cot",
                "dog",
                "dag",
                "dot",
                "cat",
            };

            Assert.AreEqual(3, new Problem_19_7().Solution(dict, "cat", "dog"));
        }
    }
}