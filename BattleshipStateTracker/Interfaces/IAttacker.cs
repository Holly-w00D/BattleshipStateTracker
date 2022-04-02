using BattleshipStateTracker.Models;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Interfaces
{
    public interface IAttacker
    {
        AttackStatus Attack(Board board, int row, int column);
    }
}
