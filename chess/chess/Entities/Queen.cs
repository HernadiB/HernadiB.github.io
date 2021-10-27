using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    class Queen : ChessPiece, Piece
    {
        string name;
        int totalMoves;
        public Queen(char color) : base(color)
        {
            setName(color);
        }
        public int getTotalMoves()
        {
            return totalMoves;
        }

        public bool setMove(ChessPiece[,] board, int currentColumn, int currentRow, int nextColumn, int nextRow)
        {
            int currentMinusNextColumn = nextColumn - currentColumn;
            int currentMinusNextRow = nextRow - currentRow;
            bool isPossible = true;
            bool diagonally = false;
            bool leftright = false;
            bool updown = false;
            char color = this.getColor();

            if (!diagonally)
            {
                int tempNextColumn = currentMinusNextColumn > 0 ? currentMinusNextColumn : -(currentMinusNextColumn);
                int tempNextRow = currentMinusNextRow > 0 ? currentMinusNextRow : -(currentMinusNextRow);
                if (tempNextColumn == tempNextRow)
                {
                    diagonally = true;
                }
            }
            if (!leftright)
            {
                if (currentMinusNextColumn == 0)
                {
                    leftright = true;
                }
            }
            if (!updown)
            {
                if (currentMinusNextRow == 0)
                {
                    updown = true;
                }
            }
            if (!diagonally && !leftright && !updown)
            {
                Console.WriteLine("A királynő csak átlósa, balra, jobbra vagy fel és le mozoghat!");
                isPossible = false;
                return isPossible;
            }

            if (board[nextColumn, nextRow].getColor() == this.getColor())
            {
                Console.WriteLine("Nem mozoghat a királynő olyan mezőre ahol saját bábu áll!");
                return false;
            }
            if (color == 'B')
            {
                if (diagonally)
                {
                    if (currentColumn > nextColumn && currentRow < nextRow)
                    {
                        for (int i = currentColumn - 1, g = currentRow + 1; isPossible && i > nextColumn && g < currentRow; i--, g++)
                        {
                            if (!(board[i, g] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                    if (currentColumn > nextColumn && currentRow > nextRow)
                    {
                        for (int i = currentColumn - 1, g = currentRow - 1; isPossible && i > nextColumn && g > nextRow; i--, g--)
                        {
                            if (!(board[i, g] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                }
                //--
                if (leftright)
                {
                    if (currentRow < nextRow && currentMinusNextColumn == 0)
                    {
                        for (int i = currentRow + 1; isPossible && i < nextRow; i++)
                        {
                            if (!(board[currentColumn, i] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
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
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                }
                if (updown)
                {
                    if (currentColumn < nextColumn && currentMinusNextRow == 0)
                    {
                        for (int i = currentColumn + 1; isPossible && i < nextColumn; i++)
                        {
                            if (!(board[i, currentRow] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                    if (currentColumn > nextColumn && currentMinusNextRow == 0)
                    {
                        for (int i = currentColumn - 1; isPossible && i > nextColumn; i--)
                        {
                            if (!(board[i, currentRow] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                }

                //-----
            }
            if (color == 'W')
            {
                if (diagonally)
                {
                    if (currentColumn < nextColumn && currentRow < nextRow)
                    {
                        for (int i = currentColumn + 1, g = currentRow + 1; i < nextColumn && g < currentRow; i++, g++)
                        {
                            if (!(board[i, g] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                    if (currentColumn < nextColumn && currentRow > nextRow)
                    {
                        for (int i = currentColumn + 1, g = currentRow - 1; !diagonally && i < nextColumn && g > nextRow; i++, g--)
                        {
                            if (!(board[i, g] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                }
                if (leftright)
                {
                    if (currentRow < nextRow && currentMinusNextColumn == 0)
                    {
                        for (int i = currentRow + 1; isPossible && i < nextRow; i++)
                        {
                            if (!(board[currentColumn, i] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
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
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                }
                if (updown)
                {
                    if (currentColumn < nextColumn && currentMinusNextRow == 0)
                    {
                        for (int i = currentColumn + 1; isPossible && i < nextColumn; i++)
                        {
                            if (!(board[i, currentRow] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                    if (currentColumn > nextColumn && currentMinusNextRow == 0)
                    {
                        for (int i = currentColumn - 1; isPossible && i > nextColumn; i--)
                        {
                            if (!(board[i, currentRow] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                isPossible = false;
                            }
                        }
                    }
                }
            }
            if (isPossible)
                totalMoves++;
            return isPossible;
        }

        public void setName(char color)
        {
            this.name = color == 'W' ? "WQ" : "BQ";
        }
        public override string ToString()
        {
            return name;
        }
    }
}
