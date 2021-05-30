
namespace FibonacciGridGame.Pages
{
    public partial class FibonacciGrid
    {
        public const int GridSize = 10;
        int[,] grid = new int[GridSize, GridSize];

        private void ProcessCellChange(int row, int col)
        {
            CellLogic.IncrementCount(grid, row, col);

            CellLogic.SetCountToZeroForFiveFibonacci(grid);
        }
    }
}
