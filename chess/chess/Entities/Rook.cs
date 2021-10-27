using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    class Rook : ChessPiece, Piece
    {
        int totalMoves = 0;
        string name;
        public Rook(char color) : base(color)
        {
            setName(color);
        }
        public bool setMove(ChessPiece[,] board, int currentColumn, int currentRow, int nextColumn, int nextRow)
        {
            int currentMinusNextColumn = nextColumn - currentColumn;
            int currentMinusNextRow = nextRow - currentRow;
            bool isPossible = true;
            if (currentColumn > nextColumn && currentMinusNextRow == 0)
            {
                for (int i = currentColumn - 1; isPossible && i > nextColumn; i--)
                {
                    if ((board[i, currentRow] is Blank))
                    {
                        isPossible = false;
                    }
                }
            }
            if (currentRow > nextRow && currentMinusNextColumn == 0)
            {
                for (int i = currentRow - 1; isPossible && i > nextRow; i--)
                {
                    if (!(board[currentColumn, i] is Blank))
                    {
                        isPossible = false;
                    }
                }
            }
            if (currentColumn < nextColumn && currentMinusNextRow == 0)
            {
                for (int i = currentColumn + 1; isPossible && i < nextColumn; i++)
                {
                    if (!(board[i, currentRow] is Blank))
                    {
                        isPossible = false;
                    }
                }
            }
            if (currentRow > nextRow && currentMinusNextColumn == 0)
            {
                for (int i = currentRow - 1; i > nextRow; i--)
                {
                    if (!(board[currentColumn, i] is Blank))
                    {
                        isPossible = false;
                    }
                }
            }

            if (!(isPossible))
                Console.WriteLine("Rook cant move over other piece");

            return isPossible;
        }
        public void setName(char color)
        {
            this.name = color == 'W' ? "WR" : "BR";
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
