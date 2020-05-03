using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Algorithms.Convertors;

namespace Algorithms.Tests.Convertors
{
    [TestClass]
    public class StringToIntList_uTests
    {
        [TestMethod]
        public void StringToIntList_inputString_returnCollection()
        {
            // arrange
            string inputString = "1234";
            List<int> expected = new List<int>() { 1, 2, 3, 4 };

            // act
            var actual = StringToIntList.Convert(inputString);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringToIntList_returnedTypeIsCollection()
        {
            // arrange
            string inputString = "1234";

            // act
            var actual = StringToIntList.Convert(inputString);

            // assert
            Assert.IsInstanceOfType(actual, typeof(List<int>));
        }
    }
}
