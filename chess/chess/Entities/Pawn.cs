using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    class Pawn : ChessPiece, Piece
    {

        int totalMoves = 0;
        string name;
        public Pawn(char color) : base(color)
        {
            setName(color);
        }
        public void setName(char color)
        {
            this.name = color == 'W' ? "WP" : "BP";
        }
        public bool setMove(ChessPiece[,] board, int currentColumn, int currentRow, int nextColumn, int nextRow) // 1 0
        {
            char currentPieceColor = this.getColor();
            int currentMinusNextColumn = nextColumn - currentColumn;
            int currentMinusNextRow = nextRow - currentRow;
            if (currentMinusNextRow != 0 && (currentMinusNextRow == -1 || currentMinusNextRow == 1) && (currentMinusNextColumn == -1 || currentMinusNextColumn == 1))
            {
                if (board[nextColumn, nextRow] is Blank)
                {
                    Console.WriteLine("A gyalog csak abba az irányba tud leütni, más esetben csak előre halad!");
                    return false;
                }
                else { totalMoves++; return true; }

            }
            else if (totalMoves > 0 && (currentMinusNextRow > 1 || currentMinusNextRow < -1 || currentMinusNextColumn > 1 || currentMinusNextColumn < -1))
            {
                Console.WriteLine("A gyalog csak átlósan és csak egy egységben tudja leütni ellenfelét!");
                return false;
            }
            if (totalMoves == 0)
            {
                if (currentColumn > nextColumn)
                {
                    bool anyPieceBlocking = false;
                    for (int i = currentColumn - 1; !anyPieceBlocking && i >= nextColumn; i--)
                    {
                        if (!(board[i, currentRow] is Blank))
                        {
                            anyPieceBlocking = true;
                            Console.WriteLine("Útban van egy másik bábu így oda nem lehet lépni!");
                            return false;
                        }
                    }
                }
                if (currentColumn < nextColumn)
                {
                    bool anyPieceBlocking = false;
                    for (int i = currentColumn + 1; !anyPieceBlocking && i <= nextColumn; i++)
                    {
                        if (!(board[i, currentRow] is Blank))
                        {
                            anyPieceBlocking = true;
                            Console.WriteLine("Útban van egy másik bábu így oda nem lehet lépni!");
                            return false;
                        }
                    }
                }
                if (currentPieceColor == 'W')
                    if (currentMinusNextRow == 0 && (currentMinusNextColumn == 1 || currentMinusNextColumn == 2))
                    {
                        totalMoves++;
                        return true;
                    }
                if (currentPieceColor == 'B')
                    if (currentMinusNextRow == 0 && (currentMinusNextColumn == -1 || currentMinusNextColumn == -2))
                    {
                        totalMoves++;
                        return true;
                    }
            }
            if (totalMoves > 0)
            {
                if (!(board[nextColumn, nextRow] is Blank))
                {
                    Console.WriteLine("Érvénytelen lépés, egy másik bábu útban van!");
                    return false;
                }
                if (currentPieceColor == 'W')
                    if (currentMinusNextColumn == 1 && currentMinusNextRow == 0)
                    {
                        totalMoves++;
                        return true;
                    }
                if (currentPieceColor == 'B')
                    if (currentMinusNextColumn == -1 && currentMinusNextRow == 0)
                    {
                        totalMoves++;
                        return true;
                    }
            }
            if (totalMoves == 0)
                Console.WriteLine("A gyalog az első körben 1 vagy 2 lépést tehet előre!");
            if (totalMoves > 0)
                Console.WriteLine("A gyalog egy lépést tehet előre!");
            return false;

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
