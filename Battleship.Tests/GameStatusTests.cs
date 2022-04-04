using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Battleship.Tests
{
    public class GameStatusTests
    {
        [Fact]
        public void ShipsSunk_GameLost()
        {
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(10, 10);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(ShipTypes.Destroyer);

            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship, board, 0, 0);

            var attacker = new Attacker();
            attacker.Attack(board, 0, 0);
            attacker.Attack(board, 0, 1);

            Assert.True(board.HasLost);
        }

        [Fact]
        public void ShipsNotSunk_GameContinue()
        {
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(10, 10);

            var shipCreator = new ShipCreator();
            var ship = shipCreator.CreateShip(ShipTypes.Destroyer);

            var shipPlacer = new ShipPlacer();
            shipPlacer.PlaceShip(ship, board, 0, 0);

            var attacker = new Attacker();
            attacker.Attack(board, 0, 0);

            Assert.False(board.HasLost);
        }

    }
}
