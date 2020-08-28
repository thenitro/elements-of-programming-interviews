using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    [TestFixture]
    public class TestProblem_8_1
    {
        [Test]
        public void Smoke()
        {
            var l1 = new LinkedListNode(2, new LinkedListNode(5, new LinkedListNode(7)));
            var l2 = new LinkedListNode(3, new LinkedListNode(6));
            
            var result = new Problem_8_1().Solution(l1, l2);
            
            Assert.NotNull(result);
            Assert.AreEqual(2, result.Data);
            Assert.AreEqual(3, result.Next.Data);
            Assert.AreEqual(5, result.Next.Next.Data);
            Assert.AreEqual(6, result.Next.Next.Next.Data);
            Assert.AreEqual(7, result.Next.Next.Next.Next.Data);
        }
        
        [Test]
        public void OneList()
        {
            var l1 = new LinkedListNode(2, new LinkedListNode(5, new LinkedListNode(7)));
            LinkedListNode l2 = null;
            
            var result = new Problem_8_1().Solution(l1, l2);
            
            Assert.NotNull(result);
            Assert.AreEqual(2, result.Data);
            Assert.AreEqual(5, result.Next.Data);
            Assert.AreEqual(7, result.Next.Next.Data);
        }
    }
}