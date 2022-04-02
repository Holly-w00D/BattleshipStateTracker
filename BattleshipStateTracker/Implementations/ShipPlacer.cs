using BattleshipStateTracker.Classes;
using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Interfaces;
using BattleshipStateTracker.Models;

namespace BattleshipStateTracker.Implementations
{
    public class ShipPlacer : IShipPlacer
    {
        public void PlaceShip(Ship ship, Board board, int row, int column)
        {
            Validate(ship, board, row, column);
            for (int i = 0; i < ship.Size; i++)
            {
                board.BoardCellStatuses[row, column + i] = BoardCellStatus.Occupied;
            }
        }
        
        private void Validate(Ship ship, Board board, int row, int column)
        {
            var errorMessage = "Ship's placement is out of bounds";

            if (row < 0 || row > board.Rows - 1)
            {
                throw new System.ArgumentOutOfRangeException(errorMessage);
            }

            if (column < 0 || column > board.Columns - 1)
            {
                throw new System.ArgumentOutOfRangeException(errorMessage);
            }

            for (int i = 0; i < ship.Size; i++)
            {
                if (row + i < 0 || row + i > board.Rows - 1)
                {
                    throw new System.ArgumentOutOfRangeException(errorMessage);
                }

                if (column + i < 0 || column + i > board.Columns - 1)
                {
                    throw new System.ArgumentOutOfRangeException(errorMessage);
                }

                if (board.BoardCellStatuses[row + i, column + i] != BoardCellStatus.Unoccupied)
                {
                    throw new System.ArgumentException("Ship's placement is invalid");
                }
            }
        }
    }
}
