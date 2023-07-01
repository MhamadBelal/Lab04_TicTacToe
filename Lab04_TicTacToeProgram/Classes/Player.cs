using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_TicTacToeProgram.Classes
{
    public class Player
    {
        public string Name { get; set; }
        /// <summary>
        /// P1 is X and P2 will be O
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Flag to determine if it is the user's turn
        /// </summary>
        public bool IsTurn { get; set; }

        /// <summary>
        /// Initializes a new instance of the Player class with the specified name and marker.
        /// </summary>
        /// <param name="Name">The Player's Name</param>
        /// <param name="Marker">The Player's Mark (O,X)</param>
        public Player(string Name,string Marker)
        {
            this.Name = Name;
            this.Marker = Marker;
        }

        /// <summary>
        /// This function return the position of the added mark. and it is used in TakeTurn method
        /// </summary>
        /// <param name="board">Board Type</param>
        /// <returns>Postion Type</returns>
        public Position GetPosition(Board board)
        {
            Position desiredCoordinate = null;
            while (desiredCoordinate is null)
            {
                Console.Write("Please select a location: ");
                Int32.TryParse(Console.ReadLine(), out int position);
                desiredCoordinate = PositionForNumber(position);
            }
            return desiredCoordinate;

        }

        /// <summary>
        /// This function will allow the player to choose a location to add their marks
        /// </summary>
        /// <param name="position">int type</param>
        /// <returns>Position Type</returns>
        public static Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(0, 0); // Top Left
                case 2: return new Position(0, 1); // Top Middle
                case 3: return new Position(0, 2); // Top Right
                case 4: return new Position(1, 0); // Middle Left
                case 5: return new Position(1, 1); // Middle Middle
                case 6: return new Position(1, 2); // Middle Right
                case 7: return new Position(2, 0); // Bottom Left
                case 8: return new Position(2, 1); // Bottom Middle 
                case 9: return new Position(2, 2); // Bottom Right

                default: return null;
            }
        }

        /// <summary>
        /// This function will allow user to play the game as turns between them
        /// </summary>
        /// <param name="board">Board type</param>
        public void TakeTurn(Board board)
        {
            IsTurn = true;

            Console.Write($"{Name}, it is your turn. ");

            Position position = GetPosition(board);

            while (!IsPositionEmpty(board, position))
            {
                Console.WriteLine("This space is already occupied");
                position = GetPosition(board);
            }

            board.GameBoard[position.Row, position.Column] = Marker;
        }

        public bool IsPositionEmpty(Board board, Position position)
        {
            return Int32.TryParse(board.GameBoard[position.Row, position.Column], out _);
        }
    }
}
