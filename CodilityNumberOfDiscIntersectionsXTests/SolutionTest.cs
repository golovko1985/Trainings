using System;
using Xunit;

namespace CodilityNumberOfDiscIntersectionsXTests
{
    public class SolutionTest
    {
        [Fact]
        public void SimpleFirstTest()
        {
            int[] arr = new int[] { 0, 1 };
            int expected = 1;
            Solution s = new();
            int actualPairs = s.solution(arr);
            Assert.Equal(expected, actualPairs);
        }

        [Fact]
        public void SampleTest()
        {
            int[] arr = new int[] { 1, 5, 2, 1, 4, 0 };
            int expected = 11;
            Solution s = new();
            int actualPairs = s.solution(arr);
            Assert.Equal(expected, actualPairs);
        }

        [Fact]
        public void OverflowTest()
        {
            int[] arr = new int[] {1, 2147483647, 0};  //2147483647
            int expected = 2;
            Solution s = new();
            int actualPairs = s.solution(arr);
            Assert.Equal(expected, actualPairs);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { 0, 1 }, 1)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { 1, 1, 1 }, 3)]
        [InlineData(new int[] { 1, 0, 1 }, 3)] //TODO: check! doesnt work properly
        [InlineData(new int[] { 1, 9, 1 }, 3)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 5)]
        [InlineData(new int[] { 2, 3, 0, 0, 4, 2, 3 }, 15)]
        public void BunchTest(int[] arr, int expected)
        {
            Solution s = new();
            int actualPairs = s.solution(arr);
            Assert.Equal(expected, actualPairs);
        }
    }
}
