using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    class King : ChessPiece, Piece
    {
        int totalMoves;
        string name;
        public King(char color) : base(color)
        {
            setName(color);
        }
        public bool setMove(ChessPiece[,] board, int currentColumn, int currentRow, int nextColumn, int nextRow)
        {
            int currentMinusNextColumn = nextColumn - currentColumn;
            int currentMinusNextRow = nextRow - currentRow;
            bool isPossible = true;
            if (board[nextColumn, nextRow] is Rook && board[nextColumn, nextRow].getColor() == this.getColor())
            {
                if (currentRow > nextRow && currentMinusNextColumn == 0)
                {
                    for (int i = currentRow - 1; isPossible && i > nextRow; i--)
                    {
                        if (!(board[currentColumn, i] is Blank))
                        {
                            isPossible = false;
                            Console.WriteLine("A sáncolás nem lehetsége, vannak más bábuk az útban!");
                            return isPossible;
                        }
                    }
                }
                if (currentRow < nextRow && currentMinusNextColumn == 0)
                {
                    for (int i = currentRow + 1; isPossible && i < nextRow; i++)
                    {
                        if (!(board[currentColumn, i] is Blank))
                        {
                            isPossible = false;
                            Console.WriteLine("A sáncolás nem lehetsége, vannak más bábuk az útban!");
                            return isPossible;
                        }
                    }
                }


                if (((Rook)board[nextColumn, nextRow]).getTotalMoves() == 0)
                {
                    if (this.getTotalMoves() == 0)
                    {
                        isPossible = true;
                        totalMoves++;
                        return isPossible;
                    }
                    else
                    {
                        Console.WriteLine("A király már mozgott előzetesen, a sáncolás csak akkor lehetséges ha ez az első lépése!");
                        isPossible = false;
                        return isPossible;
                    }
                }
                else
                {
                    Console.WriteLine("A bástya már mozgott előzetesen, a sáncolás csak akkor lehetséges ha ez az első lépése!");
                    isPossible = false;
                    return isPossible;
                }
            }

            if (currentMinusNextRow > 1 || currentMinusNextRow < -1 || currentMinusNextColumn > 1 || currentMinusNextColumn < -1)
            {
                Console.WriteLine("A király csak egyet tud mozogni bármely irányba!");
                isPossible = false;
            }
            if (isPossible && board[nextColumn, nextRow].getColor() != this.getColor())
            {
                totalMoves++;
                isPossible = true;
                return isPossible;
            }
            if (isPossible && !(board[nextColumn, nextRow] is Blank))
            {
                Console.WriteLine("A király nem léphet olyan mezőre ahol saját bábu áll!");
                isPossible = false;
            }


            return isPossible;
        }

        public void setName(char color)
        {
            this.name = color == 'W' ? "WK" : "BK";
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
