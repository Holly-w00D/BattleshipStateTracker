using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Implementations;
using Xunit;

namespace Battleship.Tests
{
    public class ShipTests
    {
        [Theory]
        [InlineData(ShipTypes.AircraftCarrier)]
        [InlineData(ShipTypes.Battleship)]
        [InlineData(ShipTypes.Cruiser)]
        [InlineData(ShipTypes.Destroyer)]
        [InlineData(ShipTypes.Submarine)]
        public void TestShipCreate(ShipTypes shipType)
        {
            //Arrange
            var shipCreator = new ShipCreator();

            //Act
            var ship = shipCreator.CreateShip(shipType);

            //Assert
            Assert.NotNull(ship);
        }
    }
}
