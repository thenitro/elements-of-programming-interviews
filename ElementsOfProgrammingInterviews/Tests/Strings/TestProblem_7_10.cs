using System;
using ElementsOfProgrammingInterviews.Strings;
using NUnit.Framework;

namespace Tests.Strings
{
    public class TestProblem_7_10
    {
        [Test]
        public void SmokeTest()
        {
            var result = new Problem_7_10().Solution("19216811");

            Assert.AreEqual(9, result.Count);
            Assert.AreEqual("1.92.168.11", result[0]);
            Assert.AreEqual("19.2.168.11", result[1]);
            Assert.AreEqual("19.21.68.11", result[2]);
            Assert.AreEqual("19.216.8.11", result[3]);
            Assert.AreEqual("19.216.81.1", result[4]);
            Assert.AreEqual("192.1.68.11", result[5]);
            Assert.AreEqual("192.16.8.11", result[6]);
            Assert.AreEqual("192.16.81.1", result[7]);
            Assert.AreEqual("192.168.1.1", result[8]);
        }
    }
}