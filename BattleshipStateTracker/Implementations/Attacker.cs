using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Interfaces;
using BattleshipStateTracker.Models;

namespace BattleshipStateTracker.Implementations
{
    public class Attacker : IAttacker
    {
        AttackStatus IAttacker.Attack(Board board, int row, int column)
        {
            Validate(board, row, column);
            
            if (board.BoardCellStatuses[row, column] == BoardCellStatus.Occupied || 
                board.BoardCellStatuses[row, column] == BoardCellStatus.Hit)
            {
                board.BoardCellStatuses[row, column] = BoardCellStatus.Hit;

                board.HitCount++;

                return AttackStatus.Hit;
            }

            board.BoardCellStatuses[row, column] = BoardCellStatus.Miss;
            return AttackStatus.Miss;
        }

        private void Validate(Board board, int row, int column)
        {
            var errorMessage = "Attack position is out of bounds";
            
            if (row < 0 || row > board.Rows - 1)
            {
                throw new System.ArgumentException(errorMessage);
            }

            if (column < 0 || column > board.Columns - 1)
            {
                throw new System.ArgumentException(errorMessage);
            }
        }
    }
}
