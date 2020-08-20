using System.Collections.Generic;

namespace ElementsOfProgrammingInterviews.Arrays
{
    public class Problem_6_2
    {
        public List<int> Solution(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                return list;
            }
            
            list[list.Count - 1] = list[list.Count - 1] + 1;

            var carry = 0;
            
            for (var i = list.Count - 1; i >= 0; i--)
            {
                list[i] += carry;
                
                if (list[i] >= 10)
                {
                    list[i] %= 10;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            if (carry == 1)
            {
                list.Insert(0, 1);
            }

            return list;
        }
    }
}