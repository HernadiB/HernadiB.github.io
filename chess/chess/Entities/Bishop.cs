using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    class Bishop : ChessPiece, Piece
    {

        int totalMoves = 0;
        string name;
        public Bishop(char color) : base(color)
        {
            setName(color);
        }
        public bool setMove(ChessPiece[,] board, int currentColumn, int currentRow, int nextColumn, int nextRow)
        {
            int currentMinusNextColumn = nextColumn - currentColumn;
            int currentMinusNextRow = nextRow - currentRow;
            bool isPossible = true;
            // --------------------------------------------------CHECKING FOR BLACK--------------------------------------
            if (currentColumn > nextColumn && currentRow > nextRow)
            {
                for (int i = currentColumn - 1, g = currentRow - 1; isPossible && i > nextColumn && g > nextRow; i--, g--)
                {
                    if (!(board[i, g] is Blank))
                    {
                        isPossible = false;
                    }
                }
            }
            if (currentColumn > nextColumn && currentRow < nextRow)
            {
                for (int i = currentColumn - 1, g = currentRow + 1; isPossible && i > nextColumn && g < nextRow; i--, g++)
                {
                    if (!(board[i, g] is Blank))
                    {
                        isPossible = false;
                    }
                }
            }
            //----------------------------------------------CHECKING FOR WHITE ----------------------------
            if (currentColumn < nextColumn && currentRow < nextRow)
            {
                for (int i = currentColumn + 1, g = currentRow + 1; isPossible && i < nextColumn && g < nextRow; i++, g++)
                {
                    if (!(board[i, g] is Blank))
                    {
                        isPossible = false;
                    }
                }
            }
            if (currentColumn < nextColumn && currentRow > nextRow)
            {
                for (int i = currentColumn + 1, g = currentRow - 1; isPossible && i < nextColumn && g > nextRow; i++, g--)
                {
                    if (!(board[i, g] is Blank))
                    {
                        isPossible = false;
                    }
                }
            }
            //------------------
            if (isPossible)
            {
                int tempNextColumn = currentMinusNextColumn > 0 ? currentMinusNextColumn : -(currentMinusNextColumn);
                int tempNextRow = currentMinusNextRow > 0 ? currentMinusNextRow : -(currentMinusNextRow);
                if (!(tempNextColumn == tempNextRow))
                {
                    Console.WriteLine("A futó csak átlósan viszont akármennyit léphet egy irányba!");
                    isPossible = false;
                    return isPossible;
                }
            }

            if (!(isPossible))
            {
                Console.WriteLine("A futó nem léphet át bábut!");
            }
            return isPossible;
        }

        public void setName(char color)
        {
            this.name = color == 'W' ? "WB" : "BB";
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
