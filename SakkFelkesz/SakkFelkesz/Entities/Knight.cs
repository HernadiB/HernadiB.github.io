using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    class Knight : ChessPiece, Piece
    {
        int osszesMozgas = 0;
        string nev;
        public Knight(char szin) : base(szin)
        {
            setNev(szin);
        }
        public bool setMozgas(ChessPiece[,] tabla, int jelenOszlop, int jelenSor, int kovetkezoOszlop, int kovetkezoSor)
        {
            int jelenlegiMinuszKovetkezoOszlop = kovetkezoOszlop - jelenOszlop;
            int jelenlegiMinuszKovetkezoSor = kovetkezoSor - jelenSor;
            if (jelenlegiMinuszKovetkezoOszlop == 1 && jelenlegiMinuszKovetkezoSor == -2 || jelenlegiMinuszKovetkezoOszlop == 1 && jelenlegiMinuszKovetkezoSor == 2 || jelenlegiMinuszKovetkezoOszlop == -2 && jelenlegiMinuszKovetkezoSor == 1 || jelenlegiMinuszKovetkezoOszlop == 2 && jelenlegiMinuszKovetkezoSor == 1 || jelenlegiMinuszKovetkezoOszlop == 2 && jelenlegiMinuszKovetkezoSor == -1 || jelenlegiMinuszKovetkezoOszlop == -2 && jelenlegiMinuszKovetkezoSor == -1 || jelenlegiMinuszKovetkezoOszlop == -1 && jelenlegiMinuszKovetkezoSor == 2 || jelenlegiMinuszKovetkezoOszlop == -1 && jelenlegiMinuszKovetkezoSor == -2)
            {
                osszesMozgas++;
                return true;
            }
            Console.WriteLine("A lovas nem tud olyan lépést végrehajtani, csak L alakban tud lépni!");
            return false;
        }

        public void setNev(char szin)
        {
            this.nev = szin == 'W' ? "WN" : "BN";
        }
        public override string ToString()
        {
            return nev;
        }
        public int getOsszesMozgas()
        {
            return osszesMozgas;
        }
    }

}
