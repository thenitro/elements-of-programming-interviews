using System.Security.Policy;
using ElementsOfProgrammingInterviews.Structures;

namespace ElementsOfProgrammingInterviews.LinkedLists
{
    public class Problem_8_2
    {
        public LinkedListNode Solution(LinkedListNode node)
        {
            if (node == null || node.Next == null)
            {
                return node;
            }
            
           LinkedListNode p = null;
           var c = node;
           LinkedListNode result = null;

           while (c != null)
           {
               var tmpC = c.Next;

               c.Next = p;

               p = c;
               c = tmpC;

               if (c != null && c.Next == null)
               {
                   result = c;
               }
           }

           return result;
        }
    }
}