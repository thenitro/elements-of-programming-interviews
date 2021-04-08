using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    public class TestProblem_8_9
    {
        [Test]
        public void Smoke()
        {
            var head = new LinkedListNode(2)
            {
                Next = new LinkedListNode(3)
                {
                    Next = new LinkedListNode(5)
                    {
                        Next = new LinkedListNode(3)
                        {
                            Next = new LinkedListNode(2)
                        }
                    }
                }
            };
            
            var solution = new Problem_8_9().Solution(head, 3);
            
            Assert.AreEqual(solution.Data, 5);
            Assert.AreEqual(solution.Next.Data, 3);
            Assert.AreEqual(solution.Next.Next.Data, 2);
            Assert.AreEqual(solution.Next.Next.Next.Data, 2);
            Assert.AreEqual(solution.Next.Next.Next.Next.Data, 3);
        }
    }
}