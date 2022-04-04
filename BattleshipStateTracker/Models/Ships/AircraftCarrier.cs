using BattleshipStateTracker.Classes;
using BattleshipStateTracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipStateTracker.Models.Ships
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier () 
        { 
            ShipType = ShipTypes.AircraftCarrier;
            Size = 5;
        }
    }
}
