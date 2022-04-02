using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipStateTracker.Interfaces
{
    interface AttackStatus
    {
        public string Hit { get; set; }
        public string Miss { get; set; }
    }
}
