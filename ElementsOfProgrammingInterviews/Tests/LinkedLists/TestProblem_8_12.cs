using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    [TestFixture]
    public class TestProblem_8_12
    {
        [Test]
        public void Smoke()
        {
            var head = new LinkedListNode(3)
            {
                Next = new LinkedListNode(2)
                {
                    Next = new LinkedListNode(2)
                    {
                        Next = new LinkedListNode(11)
                        {
                            Next = new LinkedListNode(7)
                            {
                                Next = new LinkedListNode(5)
                                {
                                    Next = new LinkedListNode(11)
                                }
                            }
                        }
                    }
                }
            };

            var solution = new Problem_8_12().Solution(head, 7);
            
            Assert.AreEqual(3, solution.Data);
            Assert.AreEqual(2, solution.Next.Data);
            Assert.AreEqual(2, solution.Next.Next.Data);
            Assert.AreEqual(5, solution.Next.Next.Next.Data);
            Assert.AreEqual(7, solution.Next.Next.Next.Next.Data);
            Assert.AreEqual(11, solution.Next.Next.Next.Next.Next.Data);
            Assert.AreEqual(11, solution.Next.Next.Next.Next.Next.Next.Data);
        }
    }
}