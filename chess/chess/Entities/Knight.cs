using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    class Knight : ChessPiece, Piece
    {
        int totalMoves = 0;
        string name;
        public Knight(char color) : base(color)
        {
            setName(color);
        }
        public bool setMove(ChessPiece[,] board, int currentColumn, int currentRow, int nextColumn, int nextRow)
        {
            int currentMinusNextColumn = nextColumn - currentColumn;
            int currentMinusNextRow = nextRow - currentRow;
            if (currentMinusNextColumn == 1 && currentMinusNextRow == -2 || currentMinusNextColumn == 1 && currentMinusNextRow == 2 || currentMinusNextColumn == -2 && currentMinusNextRow == 1 || currentMinusNextColumn == 2 && currentMinusNextRow == 1 || currentMinusNextColumn == 2 && currentMinusNextRow == -1 || currentMinusNextColumn == -2 && currentMinusNextRow == -1 || currentMinusNextColumn == -1 && currentMinusNextRow == 2 || currentMinusNextColumn == -1 && currentMinusNextRow == -2)
            {
                totalMoves++;
                return true;
            }
            Console.WriteLine("A lovas nem tud olyan lépést végrehajtani, csak L alakban tud lépni!");
            return false;
        }

        public void setName(char color)
        {
            this.name = color == 'W' ? "WN" : "BN";
        }
        public override string ToString()
        {
            return name;
        }
        public int getTotalMoves()
        {
            return totalMoves;
        }
    }
}
