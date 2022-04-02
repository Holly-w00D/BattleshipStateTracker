using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipStateTracker.Interfaces
{
    interface BoardStatus
    {
        public string Unoccupied { get; set; }
        public string Occupied { get; set; }
        public string Hit { get; set; }
        public string Miss { get; set; }
    }
}
