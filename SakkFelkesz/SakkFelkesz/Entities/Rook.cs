using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    class Rook : ChessPiece, Piece
    {
        int osszesMozgas = 0;
        string nev;
        public Rook(char szin) : base(szin)
        {
            setNev(szin);
        }
        public bool setMozgas(ChessPiece[,] tabla, int jelenOszlop, int jelenSor, int kovetkezoOszlop, int kovetkezoSor)
        {
            int jelenlegiMinuszKovetkezoOszlop = kovetkezoOszlop - jelenOszlop;
            int jelenlegiMinuszKovetkezoSor = kovetkezoSor - jelenSor;
            bool lehetsegesE = true;
            if (jelenOszlop > kovetkezoOszlop && jelenlegiMinuszKovetkezoSor == 0)
            {
                for (int i = jelenOszlop - 1; lehetsegesE && i > kovetkezoOszlop; i--)
                {
                    if ((tabla[i, jelenSor] is Blank))
                    {
                        lehetsegesE = false;
                    }
                }
            }
            if (jelenSor > kovetkezoSor && jelenlegiMinuszKovetkezoOszlop == 0)
            {
                for (int i = jelenSor - 1; lehetsegesE && i > kovetkezoSor; i--)
                {
                    if (!(tabla[jelenOszlop, i] is Blank))
                    {
                        lehetsegesE = false;
                    }
                }
            }
            if (jelenOszlop < kovetkezoOszlop && jelenlegiMinuszKovetkezoSor == 0)
            {
                for (int i = jelenOszlop + 1; lehetsegesE && i < kovetkezoOszlop; i++)
                {
                    if (!(tabla[i, jelenSor] is Blank))
                    {
                        lehetsegesE = false;
                    }
                }
            }
            if (jelenSor > kovetkezoSor && jelenlegiMinuszKovetkezoOszlop == 0)
            {
                for (int i = jelenSor - 1; i > kovetkezoSor; i--)
                {
                    if (!(tabla[jelenOszlop, i] is Blank))
                    {
                        lehetsegesE = false;
                    }
                }
            }

            if (!(lehetsegesE))
                Console.WriteLine("A bástya nem léphet át azonos bábukat!");

            return lehetsegesE;
        }
        public void setNev(char szin)
        {
            this.nev = szin == 'W' ? "WR" : "BR";
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
