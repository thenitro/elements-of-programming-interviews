using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_15
    {
        public int Solution(int[] numbers, double[] probabilities)
        {
            var map = new Dictionary<int, Tuple<double, double>>();

            var accumulator = 0.0;
                
            for (var i = 0; i < numbers.Length; i++)
            {
                var newAccumulator = accumulator + probabilities[i];
                map[numbers[i]] = new Tuple<double, double>(accumulator, newAccumulator);

                accumulator = newAccumulator;
            }

            var number = new Random().Next(0, 100) / 100.0;

            foreach (var kv in map)
            {
                if (number >= kv.Value.Item1 && number < kv.Value.Item2)
                {
                    return kv.Key;
                }
            }

            return 0;
        }
    }
}