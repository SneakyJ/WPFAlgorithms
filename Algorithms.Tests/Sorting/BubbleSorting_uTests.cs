using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sorting;
using System.Collections.Generic;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class BubbleSorting_uTests
    {
        [TestMethod]
        public void Sort_input4321_result1234()
        {
            // arrange
            List<int> input = new List<int>() { 4, 3, 2, 1 };
            List<int> expected = new List<int>() { 1, 2, 3, 4 };

            // act
            BubbleSorting x = new BubbleSorting();
            List<int> actual = x.Sort(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
