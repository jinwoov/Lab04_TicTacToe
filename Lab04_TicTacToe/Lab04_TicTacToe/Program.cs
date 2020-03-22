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
                                      
            PlayGame();
        }

        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
        static void PlayGame()
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

            //Console.WriteLine(game.Play()); 
            Player winner = game.Play();

            if (winner.Name == "Draw")
            Console.WriteLine("This was a draw");

            else
            {
                Console.WriteLine($"{winner.Name}, you were a winner");
            }

        }
    }
}
