using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    public class TestProblem_8_8
    {
        [Test]
        public void Test()
        {
            var head = new LinkedListNode(2)
            {
                Next = new LinkedListNode(2)
                {
                    Next = new LinkedListNode(3)
                    {
                        Next = new LinkedListNode(5)
                        {
                            Next = new LinkedListNode(7)
                            {
                                Next = new LinkedListNode(11)
                                {
                                    Next = new LinkedListNode(11)
                                }
                            }
                        }
                    }
                }
            };

            new Problem_8_8().Solution(head);
            
            Assert.AreEqual(2, head.Data);
            Assert.AreEqual(3, head.Next.Data);
            Assert.AreEqual(5, head.Next.Next.Data);
            Assert.AreEqual(7, head.Next.Next.Next.Data);
            Assert.AreEqual(11, head.Next.Next.Next.Next.Data);
            Assert.Null(head.Next.Next.Next.Next.Next);
        }
    }
}