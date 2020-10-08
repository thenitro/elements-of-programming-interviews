using System;

namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_3
    {
        public long Solution(long x)
        {
            var start = 0;
            var end = 63;

            while (start < end)
            {
                x = SwapBits(x, start, end);
                
                start++;
                end--;
            }

            return x;
        }

        private long SwapBits(long x, int start, int end)
        {
            if (GetBit(x, start) != GetBit(x, end))
            {
                var mask = (1L << start) | (1L << end);
                x ^= mask;
            }

            return x;
        }

        private long GetBit(long x, int i)
        {
            return (x >> i) & 1;
        }
    }
}