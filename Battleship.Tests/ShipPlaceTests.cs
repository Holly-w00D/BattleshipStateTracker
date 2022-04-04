using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Implementations;
using System;
using Xunit;

namespace Battleship.Tests
{
    public class ShipPlaceTests
    {
        [Theory]
        [InlineData(10, 10, 0, 0, ShipTypes.AircraftCarrier)]
        [InlineData(10, 10, 0, 1, ShipTypes.Battleship)]
        [InlineData(10, 10, 5, 2, ShipTypes.Cruiser)]
        [InlineData(10, 10, 7, 3, ShipTypes.Destroyer)]
        [InlineData(10, 10, 5, 4, ShipTypes.Submarine)]
        public void ValidShipPlacement_ReturnsTrue(
            int boardRows, 
            int boardColumns, 
            int placementRow, 
            int placementColumn, 
            ShipTypes shipType)
        {
            // Arrange
            
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            // Act
            var shipPlacer = new ShipPlacer();
                shipPlacer.PlaceShip(ship, board, placementRow, placementColumn);

            // Assert
            Assert.True(board.BoardCellStatuses[placementRow, placementColumn] == BoardCellStatus.Occupied &&
                        board.BoardCellStatuses[placementRow, placementColumn + ship.Size - 1] == BoardCellStatus.Occupied &&
                        board.BoardCellStatuses[placementRow, placementColumn + ship.Size - 1] == BoardCellStatus.Occupied &&
                        board.BoardCellStatuses[placementRow, placementColumn + ship.Size - 1] == BoardCellStatus.Occupied &&
                        board.BoardCellStatuses[placementRow, placementColumn + ship.Size - 1] == BoardCellStatus.Occupied
                        );
        }
        
        [Theory]
        [InlineData(10, 10, 25, 12, ShipTypes.AircraftCarrier)]
        [InlineData(10, 10, 19, 13, ShipTypes.Battleship)]
        [InlineData(10, 10, 11, 10, ShipTypes.Cruiser)]
        [InlineData(10, 10, 10, 11, ShipTypes.Destroyer)]
        [InlineData(10, 10, 12, 4, ShipTypes.Submarine)]
        public void InvalidShipPlacement_ReturnsException(
        int boardRows,
        int boardColumns,
        int placementRow,
        int placementColumn,
        ShipTypes shipType)
        {
            // Arrange
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            // Act
            var shipPlacer = new ShipPlacer();

            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => 
            shipPlacer.PlaceShip(ship, board, placementRow, placementColumn));

            // Assert
            Assert.Equal("Ship's placement is out of bounds", ex.Message);
        }
        
        [Fact]
        public void ShipPlacementOccupied_ReturnsException()
        {
            // Arrange
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(10, 10);

            var shipCreator = new ShipCreator();
            var ship1 = shipCreator.CreateShip(ShipTypes.AircraftCarrier);
            var ship2 = shipCreator.CreateShip(ShipTypes.Battleship);


            // Act
            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship1, board, 1, 1);

            ArgumentException ex = Assert.Throws<ArgumentException>(() =>
            shipPlacer.PlaceShip(ship2, board, 1, 1));

            // Assert
            Assert.Equal("Ship's placement is invalid, space is occupied", ex.Message);
        }
    }
}
