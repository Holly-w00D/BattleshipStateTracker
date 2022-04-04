using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Implementations;
using System;
using Xunit;

namespace Battleship.Tests
{
    public class AttackerTests
    {
        [Theory]
        [InlineData(10, 10, 0, 0, 0, 0, ShipTypes.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 1, ShipTypes.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 2, ShipTypes.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 3, ShipTypes.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 4, ShipTypes.AircraftCarrier, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 5, 5, ShipTypes.AircraftCarrier, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 5, ShipTypes.AircraftCarrier, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 3, 8, ShipTypes.AircraftCarrier, BoardCellStatus.Miss)]
        public void ReturnsCorrectAttackStatus_AirCraftCarrier(
        int boardRows,
        int boardColumns,
        int placementRow,
        int placementColumn,
        int attackRow,
        int attackColumn,
        ShipTypes shipType,
        BoardCellStatus boardCellStatus)
        {
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship, board, placementRow, placementColumn);

            var attacker = new Attacker();
            attacker.Attack(board, attackRow, attackColumn);

            Assert.True(board.BoardCellStatuses[attackRow, attackColumn] == boardCellStatus);
        }
        [Theory]
        [InlineData(10, 10, 0, 0, 0, 0, ShipTypes.Battleship, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 1, ShipTypes.Battleship, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 2, ShipTypes.Battleship, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 3, ShipTypes.Battleship, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 4, ShipTypes.Battleship, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 5, 5, ShipTypes.Battleship, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 5, ShipTypes.Battleship, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 3, 8, ShipTypes.Battleship, BoardCellStatus.Miss)]
        public void ReturnsCorrectAttackStatus_Battleship(
        int boardRows,
        int boardColumns,
        int placementRow,
        int placementColumn,
        int attackRow,
        int attackColumn,
        ShipTypes shipType,
        BoardCellStatus boardCellStatus)
        {
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship, board, placementRow, placementColumn);

            var attacker = new Attacker();
            attacker.Attack(board, attackRow, attackColumn);

            Assert.True(board.BoardCellStatuses[attackRow, attackColumn] == boardCellStatus);
        }
        [Theory]
        [InlineData(10, 10, 0, 0, 0, 0, ShipTypes.Cruiser, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 1, ShipTypes.Cruiser, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 2, ShipTypes.Cruiser, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 3, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 4, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 5, 5, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 5, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 3, 8, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        public void ReturnsCorrectAttackStatus_Cruiser(
        int boardRows,
        int boardColumns,
        int placementRow,
        int placementColumn,
        int attackRow,
        int attackColumn,
        ShipTypes shipType,
        BoardCellStatus boardCellStatus)
        {
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship, board, placementRow, placementColumn);

            var attacker = new Attacker();
            attacker.Attack(board, attackRow, attackColumn);

            Assert.True(board.BoardCellStatuses[attackRow, attackColumn] == boardCellStatus);
        }
        [Theory]
        [InlineData(10, 10, 0, 0, 0, 0, ShipTypes.Destroyer, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 1, ShipTypes.Destroyer, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 2, ShipTypes.Destroyer, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 3, ShipTypes.Destroyer, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 4, ShipTypes.Destroyer, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 5, 5, ShipTypes.Destroyer, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 5, ShipTypes.Destroyer, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 3, 8, ShipTypes.Destroyer, BoardCellStatus.Miss)]
        public void ReturnsCorrectAttackStatus_Destroyer(
        int boardRows,
        int boardColumns,
        int placementRow,
        int placementColumn,
        int attackRow,
        int attackColumn,
        ShipTypes shipType,
        BoardCellStatus boardCellStatus)
        {
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship, board, placementRow, placementColumn);

            var attacker = new Attacker();
            attacker.Attack(board, attackRow, attackColumn);

            Assert.True(board.BoardCellStatuses[attackRow, attackColumn] == boardCellStatus);
        }
        [Theory]
        [InlineData(10, 10, 0, 0, 0, 0, ShipTypes.Cruiser, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 1, ShipTypes.Cruiser, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 2, ShipTypes.Cruiser, BoardCellStatus.Hit)]
        [InlineData(10, 10, 0, 0, 0, 3, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 4, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 5, 5, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 0, 5, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        [InlineData(10, 10, 0, 0, 3, 8, ShipTypes.Cruiser, BoardCellStatus.Miss)]
        public void ReturnsCorrectAttackStatus_Submarine(
        int boardRows,
        int boardColumns,
        int placementRow,
        int placementColumn,
        int attackRow,
        int attackColumn,
        ShipTypes shipType,
        BoardCellStatus boardCellStatus)
        {
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship, board, placementRow, placementColumn);

            var attacker = new Attacker();
            attacker.Attack(board, attackRow, attackColumn);

            Assert.True(board.BoardCellStatuses[attackRow, attackColumn] == boardCellStatus);
        }

        [Theory]
        [InlineData(10, 10, 0, 0, 11, 11, ShipTypes.AircraftCarrier)]
        [InlineData(10, 10, 0, 0, 17, 15, ShipTypes.Battleship)]
        [InlineData(10, 10, 0, 0, 25, 12, ShipTypes.Cruiser)]
        [InlineData(10, 10, 0, 0, 11, 5, ShipTypes.Destroyer)]
        [InlineData(10, 10, 0, 0, 8, 19, ShipTypes.Submarine)]

        public void IncorrectAttackStatus_ReturnException(
                  int boardRows, int boardColumns,
                  int placementRow, int placementColumn,
                  int attackRow, int attackColumn,
                  ShipTypes shipType)
        {
            //Arrange

            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(boardRows, boardColumns);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(shipType);

            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship, board, placementRow, placementColumn);

            //Act
            var attacker = new Attacker();
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() =>
            attacker.Attack(board, attackRow, attackColumn));

            //Assert
            Assert.Equal("Attack position is out of bounds", ex.Message);
        }
    }
}