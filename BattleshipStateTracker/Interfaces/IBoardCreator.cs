using BattleshipStateTracker.Classes;
using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Models;

namespace BattleshipStateTracker.Interfaces
{
    public interface IBoardCreator
    {
        Board CreateBoard(int rows, int columns);
    }
}
