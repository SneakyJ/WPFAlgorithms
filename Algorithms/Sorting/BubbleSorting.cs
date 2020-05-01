using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class BubbleSorting
    {
        public string Sort(List<int> input)
        {
            int length = input.Count;
            int isSwaped = 0;
            for (int i = 0; i < length - 1; i++)
            {
                isSwaped = 0;
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = temp;
                        isSwaped = 1;
                    }
                }
                if (isSwaped == 0) 
                {
                    break;
                }
            }
                 
            string rest = "";
            input.ForEach(x =>
            {
                x.ToString();
                rest = rest + x;
            });
            return rest;
        }
    }
}
