using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    public class TestProblem_8_6
    {
        [Test]
        public void Test()
        {
            var head = new LinkedListNode(1);
            var toDelete = new LinkedListNode(2);
            var tail = new LinkedListNode(3);

            head.Next = toDelete;
            toDelete.Next = tail;
            
            Assert.AreEqual(2, head.Next.Data);
            
            new Problem_8_6().Solution(toDelete);

            Assert.AreEqual(3, head.Next.Data);
        }
    }
}