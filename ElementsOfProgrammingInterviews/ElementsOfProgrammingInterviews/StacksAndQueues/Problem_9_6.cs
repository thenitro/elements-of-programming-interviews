using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_6
    {
        public int[] Solution(int[] buildings)
        {
            var stack = new Stack<int>();

            foreach (var building in buildings)
            {
                while (stack.Count > 0 && building >= stack.Peek())
                {
                    stack.Pop();
                }
                
                stack.Push(building);
            }

            return stack.ToArray();
        }
    }
}