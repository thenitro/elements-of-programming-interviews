using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    [TestFixture]
    public class TestProblem_8_3
    {
        [Test]
        public void Smoke()
        {
            var node6 = new LinkedListNode(6);
            var node3 = new LinkedListNode(3, new LinkedListNode(4, new LinkedListNode(5, node6)));
            var list = new LinkedListNode(1, new LinkedListNode(2, node3));
            node6.Next = node3;

            var result = new Problem_8_3().Solution(list);
            
            Assert.NotNull(result);
            Assert.AreEqual(3, result.Data);
        }
    }
}