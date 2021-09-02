using System;
using Xunit;

namespace CodilityNumberOfDiscIntersectionsXTests
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(new int[]{0, 1}, 1)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]

        public void SimpleFirstTest(int[] arr, int expected)
        {
            Solution s = new();
            int actualPairs = s.solution(arr);

            Assert.Equal(expected, actualPairs);
        }
    }
}
