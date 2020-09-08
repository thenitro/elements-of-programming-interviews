using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    [TestFixture]
    public class TestProblem_8_4
    {
        [Test]
        public void Smoke()
        {
            var intersection = new LinkedListNode(3, new LinkedListNode(4, new LinkedListNode(5)));
            var l1 = new LinkedListNode(1, new LinkedListNode(2, intersection));
            var l2 = new LinkedListNode(6, intersection);

            var result = new Problem_8_4().Solution(l1, l2);
            
            Assert.AreEqual(result, intersection);
        }
    }
}