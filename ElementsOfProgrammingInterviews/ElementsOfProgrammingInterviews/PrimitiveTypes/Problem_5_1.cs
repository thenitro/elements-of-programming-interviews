namespace ElementsOfProgrammingInterviews.PrimitiveTypes
{
    public class Problem_5_1
    {
        /*
         * based on pop count or hamming weight
         * complexity is O(k), where k is amount of 1s in sequence 
         */
        public int Solution(int x)
        {
            var count = 0;

            while (x != 0)
            {
                x &= x - 1;//its a dropping lowest set bit of x
                count++;
            }

            return count % 2 == 0 ? 0 : 1;
        }
    }
}