using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    [TestFixture]
    public class TestProblem_8_10
    {
        [Test]
        public void SmokeTest()
        {
            var head = new LinkedListNode(0)
            {
                Next = new LinkedListNode(2)
                {
                    Next = new LinkedListNode(4)
                    {
                        Next = new LinkedListNode(1)
                        {
                            Next = new LinkedListNode(3)
                            {
                                Next = new LinkedListNode(5)
                            }
                        }
                    }
                }
            };

            var solution = new Problem_8_10().Solution(head);
            
            Assert.AreEqual(0, solution.Data);
            Assert.AreEqual(4, solution.Next.Data);
            Assert.AreEqual(3, solution.Next.Next.Data);
            Assert.AreEqual(2, solution.Next.Next.Next.Data);
            Assert.AreEqual(1, solution.Next.Next.Next.Next.Data);
            Assert.AreEqual(5, solution.Next.Next.Next.Next.Next.Data);
        }
    }
}