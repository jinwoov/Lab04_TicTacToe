using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

		/// <summary>
		/// Displays Board when its called in Play() function 
		/// </summary>
		public void DisplayBoard()
		{
			for (int i = 0; i <= 2; i++)
			{
				Console.Write($"|{GameBoard[i, 0]}|");
				Console.Write($"|{GameBoard[i, 1]}|");
				Console.WriteLine($"|{GameBoard[i, 2]}|");
			}

		}
	}
}
