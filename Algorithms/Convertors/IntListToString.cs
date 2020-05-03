using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Convertors
{
    public static class IntListToString
    {
        public static string Convert(List<int> input)
        {
            string stringResult = "";
            input.ForEach(x =>
            {
                x.ToString();
                stringResult = stringResult + x;
            });
            return stringResult;
        }
    }
}
