using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    class ChessPiece
    {
        char szin;
        public ChessPiece(char szin)
        {
            setSzin(szin);
        }

        public void setSzin(char szin)
        {
            if (szin == 'W' || szin == 'B' || szin == ' ')
            {
                this.szin = szin;
            }
            else
                Console.WriteLine("Érvénytelen színt adtál meg, válaszd a  W-t a fehérhez vagy a B-t a feketéhez");
            return;
        }
        public char getSzin()
        {
            return szin;
        }
    }


}
