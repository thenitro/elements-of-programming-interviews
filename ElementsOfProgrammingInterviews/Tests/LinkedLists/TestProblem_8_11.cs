using ElementsOfProgrammingInterviews.LinkedLists;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.LinkedLists
{
    [TestFixture]
    public class TestProblem_8_11
    {
        [Test]
        public void Smoke()
        {
            var palindromic = new LinkedListNode(2)
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
            
            var nonPalindromic = new LinkedListNode(2)
            {
                Next = new LinkedListNode(3)
                {
                    Next = new LinkedListNode(5)
                    {
                        Next = new LinkedListNode(9)
                        {
                            Next = new LinkedListNode(2)
                        }
                    }
                }
            };
            
            Assert.True(new Problem_8_11().Solution(palindromic));
            Assert.False(new Problem_8_11().Solution(nonPalindromic));
        }
    }
}