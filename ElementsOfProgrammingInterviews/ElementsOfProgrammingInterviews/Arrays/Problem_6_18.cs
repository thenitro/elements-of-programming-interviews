namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_18
    {
        public void Solution(int[,] matrix)
        {
            var size = matrix.GetLength(0) - 1;

            for (var i = 0; i < (matrix.GetLength(0) / 2); i++)
            {
                for (var j = i; j < size - i; j++)
                {
                    var temp1 = matrix[size - j, i];
                    var temp2 = matrix[size - i, size - j];
                    var temp3 = matrix[j, size - i];
                    var temp4 = matrix[i, j];

                    matrix[i, j] = temp1;
                    matrix[size - j, i] = temp2;
                    matrix[size - i, size - j] = temp3;
                    matrix[j, size - i] = temp4;
                }
            }
        }
    }
}