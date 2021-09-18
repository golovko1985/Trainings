using CodeWarsSumTwoSmallestNumbers;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CodeWarsSumTwoSmallestNumbersNTest
{

    [TestFixture]
    public class ConverterTests
    {
        //    [SetUp]
        //    public void Setup()
        //    {
        //    }

        [Test]
        public void TestSample()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, Kata.sumTwoSmallestNumbers(numbers));
        }

        [TestCase(new int[] { 19, 5, 42, 2, 77 }, ExpectedResult = 7)]
        //[TestCase(new int[] { 10, 343_445_353, 3453445, 3_453_545_353_453 }, ExpectedResult = 3453455)]

        [TestCase(new int[] { 0, 1, 2, 3}, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 0, 2, 3 }, ExpectedResult = 1)]
        [TestCase(new int[] { 10, 1, 2, 22, 3}, ExpectedResult = 3)]
        [TestCase(new int[] { 10, 1, 12, 22, 3, 2}, ExpectedResult = 3)]
        [TestCase(new int[] { 2, 3, 0, 0, 4, 2, 3 }, ExpectedResult = 0)]
        [TestCase(new int[] { 20, 30, 10, 20, 4, 55, 3, 77, 77 }, ExpectedResult = 7)]
        [TestCase(new int[] { 20, 4, 55, 3, 77, 77 }, ExpectedResult = 7)]

        //boundary condition check
        [TestCase(new int[] { 2, 3, 0}, ExpectedResult = -1)]
        [TestCase(new int[] { 2, 3 }, ExpectedResult = -1)]

        public int BunchTest( int[] numbers)
        {
            return Kata.sumTwoSmallestNumbers(numbers);
        }

    }
}