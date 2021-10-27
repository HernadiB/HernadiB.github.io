using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    class Blank : ChessPiece, Piece
    {
        string name;
        public Blank(char color) : base(color)
        {
            setName(color);
        }
        public bool setMove(ChessPiece[,] board, int column, int move, int row, int colum)
        {
            Console.WriteLine("Empty spot cannot be chosen");
            return false;
        }

        public void setName(char color)
        {
            name = color == ' ' ? "  " : "";
        }
        public override string ToString()
        {
            return name;
        }
        public int getTotalMoves()
        {
            int totalMoves = 0;
            return totalMoves;
        }
    }
}
