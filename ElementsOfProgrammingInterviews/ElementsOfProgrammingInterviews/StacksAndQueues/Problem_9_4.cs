using System.Collections.Generic;
using System.Text;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_4
    {
        public string Solution(string input)
        {
            var splitted = input.Split('/');
            var stack = new Stack<string>();

            foreach (var s in splitted)
            {
                if (s == "." || string.IsNullOrEmpty(s))
                {
                    continue;
                }
                
                stack.Push(s);
            }

            var path = new Stack<string>();

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node == "..")
                {
                    stack.Pop();
                }
                else
                {
                    path.Push(node);
                    path.Push("/");
                }
            }

            var result = new StringBuilder();

            while (path.Count > 0)
            {
                result.Append(path.Pop());
            }
            
            return result.ToString();
        }
    }
}