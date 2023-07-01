using Lab04_TicTacToeProgram.Classes;

namespace Lab04_TicTacToeTest
{
    public class UnitTest1
    {
        [Fact]
        public void Winner()
        {
            Player playerOne = new Player("Belal", "X");
            Player playerTwo = new Player("Sara", "O");

            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard = new string[,]
           {
                   {"X", "X", "X"},
                   {"O", "O", "6"},
                   {"7", "8", "9"}
           };

            bool hasWinnerr = game.CheckForWinner(game.Board);
            bool expected = true;
            Assert.Equal(hasWinnerr, expected);
        }
        
        [Fact]
        public void TestSwitchPlayer()
        {
            //Test that there is a switch in players between turns
            Game game1 = new Game(new Player("Belal", "X"), new Player("Sara", "O"));
            Player currentPlayer = game1.NextPlayer();

            game1.SwitchPlayer();
            Player switchedPlayer = game1.NextPlayer();

            Assert.NotEqual(currentPlayer, switchedPlayer);
        }
        

        [Fact]
        public void TestPlayerGetPosition()
        {
            // Test to confirm that the position the player inputs correlates to the correct index of the array
            Board board1 = new Board();
            Player playerr = new Player("Belal", "X");

            // Simulate user input
            string input = "1";
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                Position position = playerr.GetPosition(board1);

                Assert.Equal(0, position.Row);
                Assert.Equal(0, position.Column);
            }
        }

        [Fact]
        public void IsPositionEmpty_ShouldReturnFalse_WhenPositionIsOccupied()
        {
            // Arrange
            Board board = new Board();
            Position position = new Position(0, 0);
            board.GameBoard[position.Row, position.Column] = "X";

            Player player = new Player("Player1", "X");

            // Act
            bool isPositionEmpty = player.IsPositionEmpty(board, position);

            // Assert
            Assert.False(isPositionEmpty);
        }

    }
}