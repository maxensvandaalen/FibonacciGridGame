
namespace FibonacciGridGame.Pages
{
    public static class ArrayExtensions
    {
        public static T[] GetRow<T>(this T[,] grid, int row)
        {
            var rowLength = grid.GetLength(1);
            var rowVector = new T[rowLength];

            for (var i = 0; i < rowLength; i++)
            {
                rowVector[i] = grid[row, i];
            }

            return rowVector;
        }

        public static T[] GetCol<T>(this T[,] grid, int col)
        {
            var colLength = grid.GetLength(0);
            var colVector = new T[colLength];

            for (var i = 0; i < colLength; i++)
            {
                colVector[i] = grid[i, col];
            }

            return colVector;
        }
    }
}
