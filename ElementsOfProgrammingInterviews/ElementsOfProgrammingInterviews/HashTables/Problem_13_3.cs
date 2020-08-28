using System.Collections.Generic;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.HashTables
{
    public class Problem_13_3
    {
        private LinkedListNode _first;
        private Dictionary<int, LinkedListNode> _nodes;

        public Problem_13_3()
        {
            _first = null;
            _nodes = new Dictionary<int, LinkedListNode>();
        }
        
        public int Lookup(int isbn)
        {
            if (_first == null)
            {
                return -1;
            }

            if (!_nodes.ContainsKey(isbn))
            {
                return -1;
            }

            var node = _nodes[isbn];
            
            BringToFront(node);

            return node.Data;
        }
        
        public void Insert(int isbn, int price)
        {            
            var node = _nodes.ContainsKey(isbn) ? _nodes[isbn] : new LinkedListNode(price);
            
            _nodes[isbn] = node;
            
            BringToFront(node);
        }

        public void Delete(int isbn)
        {
            if (!_nodes.ContainsKey(isbn))
            {
                return;
            }

            var node = _nodes[isbn];

            _nodes.Remove(isbn);
            RemoveNode(node);
        }

        private void BringToFront(LinkedListNode node)
        {   
            RemoveNode(node);

            if (_first != null)
            {
                _first.Prev = node;
                node.Next = _first;               
            }
            
            _first = node;
        }

        private void RemoveNode(LinkedListNode node)
        {
            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }

            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }
            
            node.Prev = null;
            node.Next = null;
        }
    }
}