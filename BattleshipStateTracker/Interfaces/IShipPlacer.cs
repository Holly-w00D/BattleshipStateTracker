using BattleshipStateTracker.Classes;
using BattleshipStateTracker.Models;

namespace BattleshipStateTracker.Interfaces
{
    public interface IShipPlacer
    {
        void PlaceShip(Ship ship, Board board, int row, int column);
    }
}
