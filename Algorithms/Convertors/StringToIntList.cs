using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Convertors
{
    public static class StringToIntList
    {
        public static List<int> Convert(string input)
        {
            int charQuantity = input.Length;
            List<int> parsedIntList = new List<int>();
            List<int> revertedParsedIntList = new List<int>();
            int remainingDigits = Int32.Parse(input); // max value for int32 (int) is 2,147,483,647
            int lastDigit, listQuantity;

            while (charQuantity > 0)
            {
                lastDigit = remainingDigits % 10;
                revertedParsedIntList.Add(lastDigit);

                remainingDigits = remainingDigits / 10;
                charQuantity--;
            }

            listQuantity = revertedParsedIntList.Count;

            while ( listQuantity > 0)
            {
                parsedIntList.Add(revertedParsedIntList[listQuantity-1]);
                listQuantity--;
            }

            return parsedIntList;
        }
    }
}
