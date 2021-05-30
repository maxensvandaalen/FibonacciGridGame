using System;
using System.Collections.Generic;

namespace FibonacciGridGame.Pages
{
    public static class FibonacciLogic
    {
        public static int[,] Get2DimensionalRemoveFlagArray(int[,] grid)
        {
            var rowLength = grid.GetLength(1);
            var colLength = grid.GetLength(0);
            var removeFlagArray = new int[colLength, rowLength];

            for (int i = 0; i < rowLength; i++)
            {
                var subArray = grid.GetRow(i);

                var list = GetFibonacciIndexesToRemove(subArray);

                foreach (var index in list)
                {
                    removeFlagArray[i, index] = 1;
                }

                var reverseList = GetReverseFibonacciIndexesToRemove(subArray);

                foreach (var index in reverseList)
                {
                    removeFlagArray[i, index] = 1;
                }
            }

            for (int j = 0; j < colLength; j++)
            {
                var subArray = grid.GetCol(j);

                var list = GetFibonacciIndexesToRemove(subArray);

                foreach (var index in list)
                {
                    removeFlagArray[index, j] = 1;
                }

                var reverseList = GetReverseFibonacciIndexesToRemove(subArray);

                foreach (var index in reverseList)
                {
                    removeFlagArray[index, j] = 1;
                }
            }

            return removeFlagArray;
        }

        private static List<int> GetFibonacciIndexesToRemove(int[] array)
        {
            var length = array.GetLength(0);

            var fibonacciIndexes = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (fibonacciIndexes.Count > 4)
                {
                    break;
                }

                if (i < (length - 2) && array[i] != 0 && array[i] == array[i + 2] - array[i + 1])
                {
                    fibonacciIndexes.Add(i);
                }
                else if (i > 1 && array[i] != 0 && (array[i] == array[i - 1] + array[i - 2]))
                {
                    fibonacciIndexes.Add(i);
                }
                else
                {
                    fibonacciIndexes.Clear();
                }
            }

            return fibonacciIndexes.Count < 5 ? new List<int>() : fibonacciIndexes;
        }


        private static List<int> GetReverseFibonacciIndexesToRemove(int[] array)
        {
            var length = array.GetLength(0);
            Array.Reverse(array, 0, length);
            var reverseList = GetFibonacciIndexesToRemove(array);
            var list = new List<int>();

            foreach (var index in reverseList)
            {
                list.Add(-index + length - 1);
            }

            return list;
        }
    }
}
