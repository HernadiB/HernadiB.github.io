using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFeladat
{
    public class Piece : IPiece
    {
        public PColor PieceColor;
        public PieceType PieceType;

        public Piece(PColor pcolor, PieceType piecetype)
        {
            PColor = pcolor;
            PieceType = piecetype;
        }
    }
}
