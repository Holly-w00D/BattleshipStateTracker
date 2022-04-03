using BattleshipStateTracker.Enums;

namespace BattleshipStateTracker.Models
{
    public class AttackParameters
    {
        public int boardRows { get; set; }
        public int boardColumns { get; set; }
        public int placementRow { get; set; }
        public int placementColumn { get; set; }
        public int attackRow { get; set; }
        public int attackColumn { get; set; }
        public ShipTypes shipType { get; set; }
        public BoardCellStatus boardCellStatus { get; set; }
    }
}
