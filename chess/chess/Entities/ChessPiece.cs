using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess.Entities
{
    class ChessPiece
    {
        char color;
        public ChessPiece(char color)
        {
            setColor(color);
        }

        public void setColor(char color)
        {
            if (color == 'W' || color == 'B' || color == ' ')
            {
                this.color = color;
            }
            else
                Console.WriteLine("Érvénytelen színt adtál meg, válaszd a  W-t a fehérhez vagy a B-t a feketéhez");
            return;
        }
        public char getColor()
        {
            return color;
        }
    }
}
