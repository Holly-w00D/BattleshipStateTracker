using BattleshipStateTracker.Classes;
using BattleshipStateTracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipStateTracker.Models.Ships
{
    public class Battleship : Ship
    {
        public Battleship()
        {
            ShipType = ShipTypes.Battleship;
        }
    }
}
