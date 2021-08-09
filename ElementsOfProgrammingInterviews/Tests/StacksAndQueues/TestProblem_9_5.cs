using ElementsOfProgrammingInterviews.StacksAndQueues;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.StacksAndQueues
{
    [TestFixture]
    public class TestProblem_9_5
    {
        [Test]
        public void Smoke()
        {
            var list1 = new LinkedListNode(1);
            var list2 = new LinkedListNode(2);
            var list3 = new LinkedListNode(3);
            var list4 = new LinkedListNode(4);

            list1.Next = list2;
            list2.Next = list3;
            list3.Next = list4;

            list1.Jump = list3;
            list3.Jump = list2;
            list2.Jump = list4;
            list4.Jump = list4;

            new Problem_9_5().Solution(list1);
            
            Assert.AreEqual(0, list1.Order);
            Assert.AreEqual(2, list2.Order);
            Assert.AreEqual(1, list3.Order);
            Assert.AreEqual(3, list4.Order);
        }
    }
}