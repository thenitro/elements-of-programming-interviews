using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    [TestFixture]
    public class TestProblem_8_2
    {
        [Test]
        public void SmokeTest()
        {
            var list = new LinkedListNode(11,
                new LinkedListNode(3, new LinkedListNode(5, new LinkedListNode(7, new LinkedListNode(2)))));

            var result = new Problem_8_2().Solution(list);
            
            Assert.NotNull(result);
            Assert.AreEqual(2, result.Data);
            Assert.AreEqual(7, result.Next.Data);
            Assert.AreEqual(5, result.Next.Next.Data);
            Assert.AreEqual(3, result.Next.Next.Next.Data);
            Assert.AreEqual(11, result.Next.Next.Next.Next.Data);
            Assert.Null(result.Next.Next.Next.Next.Next);
        }
        
        [Test]
        public void OneElementInList()
        {
            var list = new LinkedListNode(11);

            var result = new Problem_8_2().Solution(list);
            
            Assert.NotNull(result);
            Assert.AreEqual(11, result.Data);
        }
    }
}