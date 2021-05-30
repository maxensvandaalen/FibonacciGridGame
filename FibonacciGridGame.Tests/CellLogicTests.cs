using System;
using FibonacciGridGame.Pages;
using Xunit;

namespace FibonacciGridGame.Tests
{
    public class CellLogicTests
    {
        [Fact]
        public void NoFibonacciSequenceLeavesCounts()
        {
            var input = new int[5, 5] { { 1, 2, 3, 4, 5 },
                                        { 1, 2, 3, 4, 5 },
                                        { 1, 2, 3, 4, 5 },
                                        { 1, 2, 3, 4, 5 },
                                        { 1, 2, 3, 4, 5 } };

            var result = new int[5, 5] { { 1, 2, 3, 4, 5 },
                                         { 1, 2, 3, 4, 5 },
                                         { 1, 2, 3, 4, 5 },
                                         { 1, 2, 3, 4, 5 },
                                         { 1, 2, 3, 4, 5 } };

            CellLogic.SetCountToZeroForFiveFibonacci(input);

            Assert.Equal(result, input);
        }

        [Fact]
        public void FiveSequentialFibonacciNumbersAreSetToZero()
        {
            var input = new int[5, 5] { { 1, 2, 1, 4, 5 },
                                        { 1, 2, 2, 4, 5 },
                                        { 1, 2, 3, 4, 5 },
                                        { 1, 2, 5, 4, 5 },
                                        { 1, 2, 8, 4, 5 } };

            var result = new int[5, 5] { { 1, 2, 0, 4, 5 },
                                         { 1, 2, 0, 4, 5 },
                                         { 1, 2, 0, 4, 5 },
                                         { 1, 2, 0, 4, 5 },
                                         { 1, 2, 0, 4, 5 } };

            CellLogic.SetCountToZeroForFiveFibonacci(input);

            Assert.Equal(result, input);
        }



        [Fact]
        public void CorrectCellsGetIncremented()
        {
            var input = new int[10, 10] { { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0},
                                          { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0} };


            var result = new int[10, 10] { { 1, 1, 1 ,1, 1, 1, 1, 1, 1, 1},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0},
                                           { 0, 0, 0 ,1, 0, 0, 0, 0, 0, 0} };

            CellLogic.IncrementCount(input, 0, 3);

            Assert.Equal(result, input);

        }
    }
}
