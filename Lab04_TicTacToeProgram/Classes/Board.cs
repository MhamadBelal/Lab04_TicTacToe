using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_TicTacToeProgram.Classes
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


        public void DisplayBoard()
        {
            /// <summary>
            /// Displays the current Board of the game. It used in Play methd.
            /// </summary>
            Console.WriteLine();
            for(int i=0;i<3;i++)
            {
                Console.Write("\t");
                for(int j = 0; j < 3;j++)
                {
                    Console.Write($"{GameBoard[i,j]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
