using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Graphs
{
    public class Problem_19_1
    {
        public List<Tuple<int, int>> Solution(int[,] matrix, Tuple<int, int> start, Tuple<int, int> exit)
        {
            var path = new List<Tuple<int, int>>();
            var visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            
            if (Dfs(matrix, start, exit, path, visited))
            {
                return path;
            }

            return null;
        }

        private bool Dfs(int[,] matrix, Tuple<int, int> currentCell, Tuple<int, int> exit, List<Tuple<int, int>> path, bool[,] visited)
        {
            if (currentCell.Item1 < 0 || currentCell.Item1 >= matrix.GetLength(0) ||
                currentCell.Item2 < 0 || currentCell.Item2 >= matrix.GetLength(1))
            {
                return false;
            }

            if (visited[currentCell.Item1, currentCell.Item2])
            {
                return false;
            }

            visited[currentCell.Item1, currentCell.Item2] = true;
            
            if (matrix[currentCell.Item1, currentCell.Item2] == 0)
            {
                return false;
            }

            if (currentCell.Item1 == exit.Item1 &&
                currentCell.Item2 == exit.Item2)
            {
                return true;
            }
            
            var neighbors = new List<Tuple<int,int>>()
            {
                new Tuple<int, int>(currentCell.Item1 - 1, currentCell.Item2),
                new Tuple<int, int>(currentCell.Item1 + 1, currentCell.Item2),
                new Tuple<int, int>(currentCell.Item1, currentCell.Item2 - 1),
                new Tuple<int, int>(currentCell.Item1, currentCell.Item2 + 1),
            };

            foreach (var neighbor in neighbors)
            {
                path.Add(neighbor);
                
                if (Dfs(matrix, neighbor, exit, path, visited))
                {
                    return true;
                }
                
                path.Remove(neighbor);
            }

            return false;
        }
    }
}