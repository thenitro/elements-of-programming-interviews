using System;
using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_16
    {
        public bool Solution(int[,] matrix)
        {
            var set = new HashSet<int>();

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0 && set.Contains(matrix[i, j]))
                    {
                        return false;
                    }

                    set.Add(matrix[i, j]);
                }
                
                set.Clear();
            }
                        
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j, i] != 0 && set.Contains(matrix[j, i]))
                    {
                        return false;
                    }

                    set.Add(matrix[j, i]);
                }
                
                set.Clear();
            }

            for (var i = 0; i < matrix.GetLength(0) / 3; i++)
            {
                for (var j = 0; j < matrix.GetLength(1) / 3; j++)
                {
                    if (!CheckBlock(i, j, matrix, set))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool CheckBlock(int blockI, int blockJ, int[,] matrix, HashSet<int> set)
        {
            blockI *= 3;
            blockJ *= 3;
            
            set.Clear();
            
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    if (matrix[blockI + i, blockJ + j] != 0 && set.Contains(matrix[blockI + i, blockJ + j]))
                    {
                        return false;
                    }
                    
                    set.Add(matrix[blockI + i, blockJ + j]);
                }
            }

            return true;
        }
    }
}