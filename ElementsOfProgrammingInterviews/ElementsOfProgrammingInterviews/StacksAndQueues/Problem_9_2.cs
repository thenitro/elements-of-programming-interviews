using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_2
    {
        public int Solution(string input)
        {
            var operations = input.Split(',');

            var nums = new Stack<int>();
            var ops = new Stack<string>();

            for (var i = operations.Length - 1; i >= 0; i--)
            {
                if (operations[i] == "-" ||
                    operations[i] == "+" ||
                    operations[i] == "*" ||
                    operations[i] == "/")
                {
                    ops.Push(operations[i]);
                }
                else
                {
                    nums.Push(int.Parse(operations[i]));
                }
            }

            while (ops.Count > 0)
            {
                var a = nums.Pop();
                var b = nums.Pop();

                var result = 0;
                
                switch (ops.Pop())
                {
                    case "-":
                    {
                        result = a - b;
                        break;
                    }
                    
                    case "+":
                    {
                        result = a + b;
                        break;
                    }
                    
                    case "*":
                    {
                        result = a * b;
                        break;
                    }
                    
                    case "/":
                    {
                        result = a / b;
                        break;
                    }
                }
                
                nums.Push(result);
            }

            return nums.Pop();
        }
    }
}