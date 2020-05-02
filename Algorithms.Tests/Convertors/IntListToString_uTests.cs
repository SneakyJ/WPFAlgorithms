using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Algorithms.Convertors;

namespace Algorithms.Tests.Convertors
{
    [TestClass]
    public class IntListToString_uTests
    {
        [TestMethod]
        public void IntListToString_inputCollection_returnString()
        {
            // arrange
            List<int> inputString = new List<int>() { 1, 2, 3, 4 };
            string expected = "1234";

            // act
            IntListToString x = new IntListToString();
            string actual = x.Convert(inputString);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntListToString_returnedTypeIsString()
        {
            // arrange
            List<int> inputString = new List<int>() { 1, 2, 3, 4 };

            // act
            IntListToString x = new IntListToString();
            var actual = x.Convert(inputString);

            // assert
            Assert.IsInstanceOfType(actual, typeof(string));
        }
    }    
}