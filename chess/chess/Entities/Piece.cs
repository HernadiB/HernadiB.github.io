using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    interface Piece
    {
        void setColor(char color);
        void setName(char color);
        bool setMove(ChessPiece[,] board, int currentColumn, int currentRow, int nextColumn, int nextRow);
        int getTotalMoves();
    }
}
