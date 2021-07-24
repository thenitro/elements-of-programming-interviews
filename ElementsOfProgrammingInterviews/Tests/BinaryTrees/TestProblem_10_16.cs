using ElementsOfProgrammingInterviews.BinaryTrees;
using ElementsOfProgrammingInterviews.Structures;
using NUnit.Framework;

namespace Tests.BinaryTrees
{
    [TestFixture]
    public class TestProblem_10_16
    {
        [Test]
        public void Smoke()
        {
            var a = new BinaryTreeNode<char>('a');
            var b = new BinaryTreeNode<char>('b');
            var c = new BinaryTreeNode<char>('c');
            var d = new BinaryTreeNode<char>('d');
            var e = new BinaryTreeNode<char>('e');
            var f = new BinaryTreeNode<char>('f');
            var g = new BinaryTreeNode<char>('g');
            var h = new BinaryTreeNode<char>('h');
            var i = new BinaryTreeNode<char>('i');
            var j = new BinaryTreeNode<char>('j');
            var k = new BinaryTreeNode<char>('k');
            var l = new BinaryTreeNode<char>('l');
            var m = new BinaryTreeNode<char>('m');
            var n = new BinaryTreeNode<char>('n');
            var o = new BinaryTreeNode<char>('o');

            a.Left = b;
            a.Right = i;

            b.Left = c;
            b.Right = f;

            c.Left = d;
            c.Right = e;

            f.Left = g;
            f.Right = h;

            i.Left = j;
            i.Right = m;

            j.Left = k;
            j.Right = l;

            m.Left = n;
            m.Right = o;
            
            new Problem_10_16().Solution(a);
            
            Assert.AreEqual(null, a.RightSibling);
            Assert.AreEqual(i, b.RightSibling);
            Assert.AreEqual(null, i.RightSibling);
            Assert.AreEqual(f, c.RightSibling);
            Assert.AreEqual(j, f.RightSibling);
            Assert.AreEqual(m, j.RightSibling);
            Assert.AreEqual(null, m.RightSibling);
            Assert.AreEqual(e, d.RightSibling);
            Assert.AreEqual(g, e.RightSibling);
            Assert.AreEqual(h, g.RightSibling);
            Assert.AreEqual(k, h.RightSibling);
            Assert.AreEqual(l, k.RightSibling);
            Assert.AreEqual(n, l.RightSibling);
            Assert.AreEqual(o, n.RightSibling);
            Assert.AreEqual(null, o.RightSibling);
        }
    }
}