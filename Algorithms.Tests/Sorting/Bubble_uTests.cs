using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sorting;
using System.Collections.Generic;

namespace Algorithms.Tests.Sorting
{
    [TestClass]
    public class Bubble_uTests
    {
        [TestMethod]
        public void Sort_input4321_result1234()
        {
            // arrange
            List<int> input = new List<int>() { 4, 3, 2, 1 };
            List<int> expected = new List<int>() { 1, 2, 3, 4 };

            // act
            List<int> actual = Bubble.Sort(input);

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sort_input4321_isSorted()
        {
            // arrange
            List<int> input = new List<int>() { 4, 3, 2, 1 };
            List<int> unsortedCollection = new List<int>() { 4, 3, 2, 1 };

            // act
            List<int> actual = Bubble.Sort(input);

            // assert
            CollectionAssert.AreNotEqual(unsortedCollection, actual);
        }
    }
}
