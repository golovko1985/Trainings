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

        [Theory]
        [InlineData(new int[] { 0, 1 }, 1)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        public void BunchTest(int[] arr, int expected)
        {
            Solution s = new();
            int actualPairs = s.solution(arr);
            Assert.Equal(expected, actualPairs);
        }
    }
}
