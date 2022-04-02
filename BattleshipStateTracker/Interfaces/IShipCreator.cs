using BattleshipStateTracker.Classes;
using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Interfaces
{
    public interface IShipCreator
    {
        Ship CreateShip(ShipTypes shipType);
    }
}
