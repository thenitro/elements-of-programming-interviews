using System.Collections.Generic;
using NUnit.Framework;

namespace ElementsOfProgrammingInterviews.BinarySearchTrees
{
    [TestFixture]
    public class TestProblem_16_1
    {
        [Test]
        public void Zero()
        {
            var stackA = new Stack<int>();
            var stackB = new Stack<int>();
            var stackC = new Stack<int>();
            
            new Problem_16_1(stackA, stackB, stackC).Solution(0, 0, 1, 2);
            
            Assert.AreEqual(0, stackA.Count);
            Assert.AreEqual(0, stackB.Count);
            Assert.AreEqual(0, stackC.Count);
        }
        
        [Test]
        public void One()
        {
            var stackA = new Stack<int>();
                stackA.Push(1);
                
            var stackB = new Stack<int>();
            var stackC = new Stack<int>();
            
            new Problem_16_1(stackA, stackB, stackC).Solution(1, 0, 1, 2);
            
            Assert.AreEqual(0, stackA.Count);
            Assert.AreEqual(1, stackB.Count);
            Assert.AreEqual(0, stackC.Count);
        }
        
        [Test]
        public void Two()
        {
            var stackA = new Stack<int>();
                stackA.Push(2);
                stackA.Push(1);
                
            var stackB = new Stack<int>();
            var stackC = new Stack<int>();
            
            new Problem_16_1(stackA, stackB, stackC).Solution(stackA.Count, 0, 1, 2);
            
            Assert.AreEqual(0, stackA.Count);
            Assert.AreEqual(2, stackB.Count);
            Assert.AreEqual(0, stackC.Count);
        }
        
        [Test]
        public void Three()
        {
            var stackA = new Stack<int>();
                stackA.Push(3);
                stackA.Push(2);
                stackA.Push(1);
                
            var stackB = new Stack<int>();
            var stackC = new Stack<int>();
            
            new Problem_16_1(stackA, stackB, stackC).Solution(stackA.Count, 0, 1, 2);
            
            Assert.AreEqual(0, stackA.Count);
            Assert.AreEqual(3, stackB.Count);
            Assert.AreEqual(0, stackC.Count);
        }
        
        [Test]
        public void Six()
        {
            var stackA = new Stack<int>();
                stackA.Push(6);
                stackA.Push(5);
                stackA.Push(4);
                stackA.Push(3);
                stackA.Push(2);
                stackA.Push(1);
                
            var stackB = new Stack<int>();
            var stackC = new Stack<int>();

            var count = stackA.Count;
            
            new Problem_16_1(stackA, stackB, stackC).Solution(count, 0, 1, 2);
            
            Assert.AreEqual(0, stackA.Count);
            Assert.AreEqual(count, stackB.Count);
            Assert.AreEqual(0, stackC.Count);
        }
    }
}