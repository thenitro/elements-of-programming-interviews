using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    [TestFixture]
    public class TestProblem_8_7
    {
        [Test]
        public void Smoke()
        {
            var head = new LinkedListNode(1,
                new LinkedListNode(2,
                    new LinkedListNode(3, new LinkedListNode(4, new LinkedListNode(7, new LinkedListNode(5))))));

            head = new Problem_8_7().Solution(head, 2);
            
            Assert.AreEqual(1, head.Data);
            Assert.AreEqual(2, head.Next.Data);
            Assert.AreEqual(3, head.Next.Next.Data);
            Assert.AreEqual(4, head.Next.Next.Next.Data);
            Assert.AreEqual(5, head.Next.Next.Next.Next.Data);
            Assert.Null(head.Next.Next.Next.Next.Next);
        }
    }
}