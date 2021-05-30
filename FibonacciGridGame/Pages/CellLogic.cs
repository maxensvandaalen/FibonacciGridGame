
namespace FibonacciGridGame.Pages
{
    public static class CellLogic
    {
        public static void IncrementCount(int[,] grid, int row, int col)
        {
            var rowLength = grid.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                grid[row, i]++;
            }

            var colLength = grid.GetLength(0);

            for (int j = 0; j < colLength; j++)
            {
                grid[j, col]++;
            }

            grid[row, col]--;
        }


        public static void SetCountToZeroForFiveFibonacci(int[,] grid)
        {
            var removeGrid = FibonacciLogic.Get2DimensionalRemoveFlagArray(grid);

            var rowLength = grid.GetLength(1);
            var colLength = grid.GetLength(0);

            for (int i = 0; i < colLength; i++)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    if (removeGrid[i, j] == 1)
                    {
                        grid[i, j] = 0;
                    }
                }
            }
        }
    }
}
