using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Models
{
    public class PlaceShipParameters
    {
        public int boardRows { get; set; }
        public int boardColumns { get; set; }
        public int placementRow { get; set; }
        public int placementColumn { get; set; }
        public ShipTypes shipType { get; set; }
    }
}
