using System;

namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_2
    {
        public long Solution(long x, int i, int j)
        {
            if (((x >> i) & 1) != ((x >> j) & 1))
            {
                var bitMask = (1L << i) | (1L << j);
                x ^= bitMask;
            }

            return x;
        }
    }
}