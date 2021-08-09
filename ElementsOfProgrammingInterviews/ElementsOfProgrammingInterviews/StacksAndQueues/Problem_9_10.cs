using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.StacksAndQueues
{
    public class Problem_9_10
    {
        private int[] queue;
        private int pointer;
        
        private Stack<int> maxStack;
        private int currentMax;

        public Problem_9_10(int size)
        {
            queue = new int[size];
            pointer = 0;
            maxStack = new Stack<int>();
            currentMax = int.MinValue;
        }

        public void Enqueue(int x)
        {
            queue[pointer] = x;
            pointer++;

            currentMax = Math.Max(currentMax, x);
            maxStack.Push(currentMax);
        }

        public int Dequeue()
        {
            pointer--;
            
            var value = queue[pointer];
            maxStack.Pop();
            currentMax = maxStack.Peek();

            return value;
        }

        public int Peek()
        {
            return queue[pointer - 1];
        }

        public int Max()
        {
            return currentMax;
        }
    }
}