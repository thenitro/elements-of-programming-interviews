using System.Collections.Generic;
using System.Threading;

namespace ElementsOfProgrammingInterviews.Graphs
{
    public class Problem_19_2
    {
        public void Solution(int x, int y, int[][] matrix)
        {
            var queue = new Queue<Coordinates>();
                queue.Enqueue(new Coordinates(x, y));

            var colorToPaint = matrix[x][y];
                
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node.X < 0 || node.X >= matrix.Length |
                    node.Y < 0 || node.Y >= matrix[node.X].Length)
                {
                    continue;
                }
                
                if (matrix[node.X][node.Y] != colorToPaint)
                {
                    continue;
                }

                matrix[node.X][node.Y] = colorToPaint == 0 ? 1 : 0;
                
                queue.Enqueue(new Coordinates(node.X + 1, node.Y));
                queue.Enqueue(new Coordinates(node.X - 1, node.Y));
                queue.Enqueue(new Coordinates(node.X, node.Y + 1));
                queue.Enqueue(new Coordinates(node.X, node.Y - 1));
            }
        }

        private class Coordinates
        {
            public int X;
            public int Y;

            public Coordinates(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}