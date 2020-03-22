using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace TestForTicTacToe
{
    public class UnitTest1
    {
        [Fact]
        public void CreateAPlayerAndInstantiateIntoGame()
        {
            Player playerOne = new Player();

            playerOne.Name = "Mario";

            Assert.Equal("Mario", playerOne.Name);
        }

        [Fact]
        public void CanMakeMarker()
        {
            Player playerOne = new Player();

            playerOne.Marker = "O";

            Assert.Equal("O", playerOne.Marker);
        }

        [Fact]
        public void CheckingInForWinner()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();


            Game game = new Game(playerOne, playerTwo);

            string[,] ReplaceBoard = new string[,]
            {
                {"O", "O", "O"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };

            game.Board.GameBoard = ReplaceBoard;

            bool winnerWinnerChickenDinner = game.CheckForWinner(game.Board);

            Assert.True(winnerWinnerChickenDinner);
        }

        [Fact]
        public void CheckIfTurnChanges()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            playerOne.IsTurn = true;
            playerTwo.IsTurn = false;


            Game game = new Game(playerOne, playerTwo);

            game.SwitchPlayer();

            Assert.True(playerTwo.IsTurn);
        }

        [Fact]
        public void CheckIfInputIsSameAsArrayIndex()
        {
            Position position = Player.PositionForNumber(3);

            Board board = new Board();

            Assert.Equal("3", board.GameBoard[position.Row, position.Column]); 
        }


    }
}
