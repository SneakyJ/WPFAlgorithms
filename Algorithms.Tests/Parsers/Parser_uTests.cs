using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Parsers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests.Parsers
{
    [TestClass]
    public class Parser_uTests
    {
        [TestMethod]
        public void Parser_StringToIntList_returnCollection() 
        {
            // arrange
            string inputString = "1234";
            List<int> expected = new List<int>() { 1, 2, 3, 4 };

            // act
            Parser x = new Parser();
            var actual = x.StringToIntList(inputString);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Parser_StringToIntList_returnedListOfInt()
        {
            // arrange
            string inputString = "1234";

            // act
            Parser x = new Parser();
            var actual = x.StringToIntList(inputString);

            // assert
            Assert.IsInstanceOfType(actual, typeof(List<int>));
        }
    }
}
