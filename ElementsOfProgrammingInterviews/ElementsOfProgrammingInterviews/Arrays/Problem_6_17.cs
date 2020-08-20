using System;
using System.Collections.Generic;
using System.Xml;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_17
    {
        public List<int> Solution(int[,] matrix)
        {
            var sx = 0;
            var ex = matrix.GetLength(0) - 1;

            var sy = 0;
            var ey = matrix.GetLength(1) - 1;

            var result = new List<int>();
            
            while (sx <= ex && sy <= ey)
            {
                for (var x = sx; x <= ex; x++)
                {
                    result.Add(matrix[sy, x]);
                }
                sy++;

                for (var y = sy; y <= ey; y++)
                {
                    result.Add(matrix[y, ex]);
                }
                ex--;

                if (!(sx <= ex && sy <= ey))
                {
                    break;
                }
                
                for (var x = ex; x >= sx; x--)
                {
                    result.Add(matrix[ey, x]);
                }
                ey--;
                
                for (var y = ey; y >= sy; y--)
                {
                    result.Add(matrix[y, sx]);
                }
                sx++;
            }

            return result;
        }
    }
}