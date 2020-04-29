using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class BubbleSorting
    {
        public string Sort(string inputString)
        {
            int length = 10;
            int[] array = new int[] { 1,2,3,3};
            for (int i = 0; i < length - 1; i++)
            {
                //int flag = 0;
                for (int j = 0; j < length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        //flag = 1;
                    }
                }
            }

            //for (int i = 0; i < array.Length; i++)
            //{
            //    result = result + array[i].ToString()+" ";
            //}                   
            return "result";
        }
    }
}
