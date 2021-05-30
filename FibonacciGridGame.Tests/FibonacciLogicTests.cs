using System;
using FibonacciGridGame.Pages;
using Xunit;

namespace FibonacciGridGame.Tests
{
    public class FibonacciLogicTests
    {
        [Fact]
        public void NoFibonacciSequenceReturnsOnlyZeros()
        {
            var inputArray = new int[5, 5]{ { 1,1,1,1,1 },
                                            { 1,1,1,1,1 },
                                            { 1,1,1,1,1 },
                                            { 1,1,1,1,1 },
                                            { 1,1,1,1,1 } };

            var expectedRemoveFlagArray = new int[5, 5]{ { 0,0,0,0,0 },
                                                         { 0,0,0,0,0 },
                                                         { 0,0,0,0,0 },
                                                         { 0,0,0,0,0 },
                                                         { 0,0,0,0,0 } };

            var result = FibonacciLogic.Get2DimensionalRemoveFlagArray(inputArray);

            Assert.Equal(result, expectedRemoveFlagArray);

        }

        [Fact]
        public void FiveVerticalSequentialFibonacciAreFound()
        {
            var inputArray = new int[5, 5]{ { 2,1,2,3,5 },
                                            { 3,1,1,1,1 },
                                            { 5,1,1,1,1 },
                                            { 8,1,1,1,1 },
                                            { 13,1,1,1,1 } };

            var expectedRemoveFlagArray = new int[5, 5]{ { 1,0,0,0,0 },
                                                         { 1,0,0,0,0 },
                                                         { 1,0,0,0,0 },
                                                         { 1,0,0,0,0 },
                                                         { 1,0,0,0,0 } };

            var result = FibonacciLogic.Get2DimensionalRemoveFlagArray(inputArray);

            Assert.Equal(result, expectedRemoveFlagArray);

        }

        [Fact]
        public void FiveReverseSequentialFibonacciAreFound()
        {
            var inputArray = new int[5, 5]{ { 21,13,8,5,3 },
                                            { 0,0,0,0,0 },
                                            { 0,0,0,0,0 },
                                            { 0,0,0,0,0 },
                                            { 0,0,0,0,0 } };

            var expectedRemoveFlagArray = new int[5, 5]{ { 1,1,1,1,1 },
                                                         { 0,0,0,0,0 },
                                                         { 0,0,0,0,0 },
                                                         { 0,0,0,0,0 },
                                                         { 0,0,0,0,0 } };

            var result = FibonacciLogic.Get2DimensionalRemoveFlagArray(inputArray);

            Assert.Equal(result, expectedRemoveFlagArray);

        }


        [Fact]
        public void FiveHorizontalSequentialFibonacciAreFound()
        {
            var inputArray = new int[7, 7]{ { 0,1,1,2,3,5,0 },
                                            { 1,1,1,1,1,1,1 },
                                            { 1,1,1,1,1,1,1 },
                                            { 1,1,1,1,1,1,1 },
                                            { 1,1,1,1,1,1,1 },
                                            { 1,1,1,1,1,1,1 },
                                            { 1,1,1,1,1,1,1 } };

            var expectedRemoveFlagArray = new int[7, 7]{ { 0,1,1,1,1,1,0 },
                                                         { 0,0,0,0,0,0,0 },
                                                         { 0,0,0,0,0,0,0 },
                                                         { 0,0,0,0,0,0,0 },
                                                         { 0,0,0,0,0,0,0 },
                                                         { 0,0,0,0,0,0,0 },
                                                         { 0,0,0,0,0,0,0 } };

            var result = FibonacciLogic.Get2DimensionalRemoveFlagArray(inputArray);

            Assert.Equal(result, expectedRemoveFlagArray);

        }
    }
}
