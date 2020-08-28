using ElementsOfProgrammingInterviews.HashTables;
using NUnit.Framework;

namespace Tests.Searching
{
    [TestFixture]
    public class TestProblem_13_3
    {
        [Test]
        public void Smoke()
        {
            var lru = new Problem_13_3();
            
            Assert.AreEqual(-1, lru.Lookup(111111111));
            
            lru.Insert(111111111, 666);
            Assert.AreEqual(666, lru.Lookup(111111111));
            
            lru.Insert(111111112, 999);
            Assert.AreEqual(999, lru.Lookup(111111112));
            
            lru.Delete(111111111);
            Assert.AreEqual(-1, lru.Lookup(111111111));
        }
    }
}