using System;
using Xunit;

namespace CodilityNumberOfDiscIntersectionsXTests
{
    public class SolutionTest
    {
        [Fact]
        public void SimpleFirstTest()
        {
            //arrange
            int[] arr = new int[] { 0, 1 };
            int expected = 1;

            //act
            Solution s = new();
            int actualPairs = s.solution(arr);

            //assert
            Assert.Equal(expected, actualPairs);

        }
    }
}
