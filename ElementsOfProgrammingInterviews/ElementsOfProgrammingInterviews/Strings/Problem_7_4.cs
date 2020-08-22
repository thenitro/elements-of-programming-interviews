using System;

namespace ElementsOfProgrammingInterviews.Strings
{
    public class Problem_7_4
    {
        public int Solution(char[] array, int size)
        {
            var writeIndex = 0;
            var aCounter = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] != 'b')
                {
                    array[writeIndex++] = array[i];
                }

                if (array[i] == 'a')
                {
                    aCounter++;
                }
            }

            var currentIndex = writeIndex - 1;
            writeIndex = writeIndex + aCounter - 1;

            var finalSize = writeIndex + 1;
            while (currentIndex >= 0)
            {
                if (array[currentIndex] == 'a')
                {
                    array[writeIndex--] = 'd';
                    array[writeIndex--] = 'd';
                }
                else
                {
                    array[writeIndex--] = array[currentIndex];
                }
                
                currentIndex--;
            }

            Console.WriteLine(string.Join("", array));
            
            return finalSize;
        }
    }
}