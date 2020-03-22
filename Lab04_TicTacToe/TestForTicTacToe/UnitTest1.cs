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
        public void CheckIfWinner()
        {
            Player playerOne = new Player();
            Player two = new Player();

            Game game = new Game(playerOne, two);

            game.CheckForWinner(game.Board);
        }
    }
}
