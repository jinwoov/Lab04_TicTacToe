using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
                    TtttttttttttttttttT        TttttttttttttttttT        TttttttttttttttttT  
                            tt                        tt                        tt
                            tt  tt   tttt             tt   tt      tttt         tt    tt       tt
                            tt  tt tt                 tt  tt tt   tt            tt  tt  tt   tt  tt
                            tt  tt tt                 tt  ttttt   tt            tt  tt  tt   tttttt
                            TT  tt   tttt             TT  tt tt    tttt         TT    tt     tt
                                                                                              tttt");
            Console.WriteLine("");

            bool startGame = false;
            while(!startGame)
            {
            startGame = PlayGame();
            }
        }

        /// <summary>
        /// Starts the game when the application is ran
        /// </summary>
        static bool PlayGame()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();

            // creating a player name
            Console.WriteLine("Player One, Whats your name?");
            playerOne.Name = Console.ReadLine();
            Console.WriteLine("Player Two, Whats your name?");
            playerTwo.Name = Console.ReadLine();

            // Instantiating Player to the board
            Game game = new Game(playerOne, playerTwo);

            Player winner = game.Play();

            if (winner.Name == "Draw")
            {
                Console.WriteLine("Close game, its a draw");
            }

            else
            {
                Console.WriteLine($"{winner.Name}, you are da winner");
            }

            Console.WriteLine("Would you like to play again? (y)es/(n)o ?");
            string userInput = Console.ReadLine();

            if (userInput == "y" || userInput == "yes" || userInput == "Yes" || userInput == "Y")
                return false;
            else
                return true;
                     
        }
    }
}
