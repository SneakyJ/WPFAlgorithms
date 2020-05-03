using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class Selection
    {
        public static List<int> Sort(List<int> input)
        {
            for (int i = 0; i < input.Count-1; i++) 
            {
                int min = i;
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[j] < input[min]) 
                    {
                        min = j;
                    }
                    int temp = input[i];
                    input[i] = input[min];
                    input[min] = temp;
                }
            }
            return input;
        }
    }
}
