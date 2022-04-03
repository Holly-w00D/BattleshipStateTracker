using BattleshipStateTracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipStateTracker.Classes
{
    public abstract class Ship
    {
        public ShipTypes ShipType { get; set; }
        public int Size { get; set; }
    }
}
