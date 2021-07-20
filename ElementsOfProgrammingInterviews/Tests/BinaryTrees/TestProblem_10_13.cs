using ElementsOfProgrammingInterviews.BinaryTrees;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_13
    {
        [Test]
        public void Smoke()
        {
            var root = new Problem_10_13()
                .Solution("H,B,F,null,null,E,A,null,null,null,C,null,D,null,G,I,null,null,null");
            
            Assert.AreEqual("H", root.Data);
            Assert.AreEqual("B", root.Left.Data);
            Assert.AreEqual("F", root.Left.Left.Data);
            Assert.AreEqual("E", root.Left.Right.Data);
            Assert.AreEqual("A", root.Left.Right.Left.Data);
            Assert.AreEqual("C", root.Right.Data);
            Assert.AreEqual("D", root.Right.Right.Data);
            Assert.AreEqual("G", root.Right.Right.Right.Data);
            Assert.AreEqual("I", root.Right.Right.Right.Left.Data);
        }
    }
}