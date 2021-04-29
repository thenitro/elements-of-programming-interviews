using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    public class TestProblem_8_13
    {
        [Test]
        public void SmokeTest()
        {
            var l1 = new LinkedListNode(3)
            {
                Next = new LinkedListNode(1)
                {
                    Next = new LinkedListNode(4)
                }
            };

            var l2 = new LinkedListNode(7)
            {
                Next = new LinkedListNode(0)
                {
                    Next = new LinkedListNode(9)
                }
            };

            var result = new Problem_8_13().Solution(l1, l2);
            
            Assert.AreEqual(0, result.Data);
            Assert.AreEqual(2, result.Next.Data);
            Assert.AreEqual(3, result.Next.Next.Data);
            Assert.AreEqual(1, result.Next.Next.Next.Data);
        }
    }
}