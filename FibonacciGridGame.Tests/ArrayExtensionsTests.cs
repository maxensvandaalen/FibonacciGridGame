using FibonacciGridGame.Pages;
using Xunit;

namespace FibonacciGridGame.Tests
{
    public class ArrayExtensionsTests
    {
        [Fact]
        public void GetRowReturnsRow()
        {
            var grid = new int[2, 2] { { 0, 1 }, { 2, 3 } };

            var result = ArrayExtensions.GetRow(grid, 1);

            var expectedResult = new int[2] { 2, 3 };

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void GetColReturnsColumn()
        {
            var grid = new int[2, 2] { { 0, 1 }, { 2, 3 } };

            var result = ArrayExtensions.GetCol(grid, 1);

            var expectedResult = new int[2] { 1, 3 };

            Assert.Equal(result, expectedResult);
        }
    }
}
