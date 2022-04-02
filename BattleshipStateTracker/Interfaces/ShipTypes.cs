using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipStateTracker.Interfaces
{
    interface ShipTypes
    {
        public string AircraftCarrier { get; set; }
        public string Battleship { get; set; }
        public string Cruiser { get; set; }
        public string Submarine { get; set; }
        public string Destroyer { get; set; }
    }
}
