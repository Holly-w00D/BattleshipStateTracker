using BattleshipStateTracker.Classes;
using BattleshipStateTracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipStateTracker.Models.Ships
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            ShipType = ShipTypes.Cruiser;
            Size = 3;
        }
    }
}
