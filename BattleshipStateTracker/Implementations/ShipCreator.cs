using BattleshipStateTracker.Classes;
using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Interfaces;
using BattleshipStateTracker.Models.Ships;
using System;

namespace BattleshipStateTracker.Implementations
{
    public class ShipCreator : IShipCreator
    {
        public Ship CreateShip(ShipTypes shipType)
        {
            try
            {
                switch (shipType)
                {
                    case ShipTypes.AircraftCarrier:
                        return new AircraftCarrier();
                    case ShipTypes.Battleship:
                        return new Battleship();
                    case ShipTypes.Cruiser:
                        return new Cruiser();
                    case ShipTypes.Submarine:
                        return new Submarine();
                    case ShipTypes.Destroyer:
                        return new Destroyer();
                    default:
                        return new AircraftCarrier();
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception($"Error creating ship: {ex.Message}");
            }
        }
    }
}
