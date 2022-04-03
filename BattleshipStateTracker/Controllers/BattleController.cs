using BattleshipStateTracker.Enums;
using BattleshipStateTracker.Implementations;
using BattleshipStateTracker.Interfaces;
using BattleshipStateTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace BattleshipStateTracker.Controllers
{
    [Route("api/v1/battle")]
    [ApiController]
    public class BattleController : ControllerBase
    {
        [Route("create")]
        [HttpPost]
        public ActionResult<IBoardCreator> CreateBoard([FromBody] BoardParameters newBoard)
        {
            try
            {
                var boardCreate = new BoardCreator();
                var board = boardCreate.CreateBoard(newBoard.Row, newBoard.Column);

                return Ok("Successfully created board with " + newBoard.Row + " rows and " + newBoard.Column + " columns");
            }
            catch (System.Exception)
            {
                return BadRequest("Failed");
            }
        }

        [Route("place")]
        [HttpPost]
        public ActionResult PlaceShip([FromBody] PlaceShipParameters body)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(body.boardRows, body.boardColumns);

                var shipCreator = new ShipCreator();
                var ship = shipCreator.CreateShip(body.shipType);

                var shipPlacer = new ShipPlacer();
                    shipPlacer.PlaceShip(ship, board, body.placementRow, body.placementColumn);


                return Ok("Successfully placed ship of type " + body.shipType + " at row " + body.placementRow + " and column " + body.placementColumn);
            }
            catch (System.Exception)
            {
                return BadRequest("Failed");
            }
        }

        [Route("attack")]
        [HttpPost]
        public ActionResult Attacker([FromBody] AttackParameters attack)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(attack.boardRows, attack.boardColumns);

                var shipCreator = new ShipCreator();
                var ship = shipCreator.CreateShip(attack.shipType);

                var shipPlacer = new ShipPlacer();
                shipPlacer.PlaceShip(ship, board, attack.placementRow, attack.placementColumn);

                var attacker = new Attacker();
                var result = attacker.Attack(board, attack.attackRow, attack.attackColumn);
                return Ok(result == AttackStatus.Hit ? "Hit" : "Miss");
            }
            catch (System.Exception)
            {
                return BadRequest("Failed");
            }
        }
    }
}