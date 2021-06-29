using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_3
    {
        public bool Solution(string input)
        {
            var mainStack = new Stack<char>();

            foreach (var c in input)
            {
                mainStack.Push(c);
            }

            var currStack = new Stack<char>();

            while (mainStack.Count > 0)
            {
                var bracket = mainStack.Pop();
                
                if (currStack.Count == 0 || !IsCorrectBracket(currStack.Peek(), bracket))
                {
                    currStack.Push(bracket);
                }
                else
                {
                    currStack.Pop();
                }
            }
            
            return mainStack.Count == 0 && currStack.Count == 0;
        }

        private bool IsCorrectBracket(char closing, char opening)
        {
            if (opening == '[' && closing == ']')
            {
                return true;
            }
            
            if (opening == '(' && closing == ')')
            {
                return true;
            }
            
            if (opening == '{' && closing == '}')
            {
                return true;
            }
            
            return false;
        }
    }
}