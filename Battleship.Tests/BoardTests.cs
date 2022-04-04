using BattleshipStateTracker.Implementations;
using Xunit;

namespace Battleship.Tests
{
    public class BoardTests
    {
        [Theory]
        [InlineData(10, 10)]
        [InlineData(20, 20)]
        public void TestBoardCreate(int rows, int columns)
        {
            //Arrange
            var boardCreator = new BoardCreator();

            //Act
            var board = boardCreator.CreateBoard(rows, columns);

            //Assert
            Assert.Equal(rows * columns, board.BoardCellStatuses.Length);
        }
    }
}
