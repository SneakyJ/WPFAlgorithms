using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Parser
{
    class StringToIntArrayParser
    {
        public List<int> toIntList(string input)
        {
            List<int> parsedList = new List<int>();

            int intInput = Int32.Parse(input);

            parsedList.Add(intInput);
            return parsedList;
        }
    }
}
