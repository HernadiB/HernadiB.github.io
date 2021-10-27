using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    class Blank : ChessPiece, Piece
    {
        string nev;
        public Blank(char szin) : base(szin)
        {
            setNev(szin);
        }
        public bool setMozgas(ChessPiece[,] tabla, int a, int b, int c, int d)
        {
            Console.WriteLine("Üres mezőt nem lehet kiválasztani!");
            return false;
        }

        public void setNev(char szin)
        {
            nev = szin == ' ' ? "  " : "  ";
        }
        public override string ToString()
        {
            return nev;
        }
        public int getOsszesMozgas()
        {
            int osszesMozgas = 0;
            return osszesMozgas;
        }
    }


}
