using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    class King : ChessPiece, Piece
    {
        int osszesMozgas;
        string nev;
        public King(char szin) : base(szin)
        {
            setNev(szin);
        }
        public bool setMozgas(ChessPiece[,] tabla, int jelenOszlop, int jelenSor, int kovetkezoOszlop, int kovetkezoSor)
        {
            int jelenlegiMinuszKovetkezoOszlop = kovetkezoOszlop - jelenOszlop;
            int jelenlegiMinuszKovetkezoSor = kovetkezoSor - jelenSor;
            bool lehetsegesE = true;
            if (tabla[kovetkezoOszlop, kovetkezoSor] is Rook && tabla[kovetkezoOszlop, kovetkezoSor].getSzin() == this.getSzin())
            {
                if (jelenSor > kovetkezoSor && jelenlegiMinuszKovetkezoOszlop == 0)
                {
                    for (int i = jelenSor - 1; lehetsegesE && i > kovetkezoSor; i--)
                    {
                        if (!(tabla[jelenOszlop, i] is Blank))
                        {
                            lehetsegesE = false;
                            Console.WriteLine("A sáncolás nem lehetsége, vannak más bábuk az útban!");
                            return lehetsegesE;
                        }
                    }
                }
                if (jelenSor < kovetkezoSor && jelenlegiMinuszKovetkezoOszlop == 0)
                {
                    for (int i = jelenSor + 1; lehetsegesE && i < kovetkezoSor; i++)
                    {
                        if (!(tabla[jelenOszlop, i] is Blank))
                        {
                            lehetsegesE = false;
                            Console.WriteLine("A sáncolás nem lehetsége, vannak más bábuk az útban!");
                            return lehetsegesE;
                        }
                    }
                }


                if (((Rook)tabla[kovetkezoOszlop, kovetkezoSor]).getOsszesMozgas() == 0)
                {
                    if (this.getOsszesMozgas() == 0)
                    {
                        lehetsegesE = true;
                        osszesMozgas++;
                        return lehetsegesE;
                    }
                    else
                    {
                        Console.WriteLine("A király már mozgott előzetesen, a sáncolás csak akkor lehetséges ha ez az első lépése!");
                        lehetsegesE = false;
                        return lehetsegesE;
                    }
                }
                else
                {
                    Console.WriteLine("A bástya már mozgott előzetesen, a sáncolás csak akkor lehetséges ha ez az első lépése!");
                    lehetsegesE = false;
                    return lehetsegesE;
                }
            }

            if (jelenlegiMinuszKovetkezoSor > 1 || jelenlegiMinuszKovetkezoSor < -1 || jelenlegiMinuszKovetkezoOszlop > 1 || jelenlegiMinuszKovetkezoOszlop < -1)
            {
                Console.WriteLine("A király csak egyet tud mozogni bármely irányba!");
                lehetsegesE = false;
            }
            if (lehetsegesE && tabla[kovetkezoOszlop, kovetkezoSor].getSzin() != this.getSzin())
            {
                osszesMozgas++;
                lehetsegesE = true;
                return lehetsegesE;
            }
            if (lehetsegesE && !(tabla[kovetkezoOszlop, kovetkezoSor] is Blank))
            {
                Console.WriteLine("A király nem léphet olyan mezőre ahol saját bábu áll!");
                lehetsegesE = false;
            }


            return lehetsegesE;
        }

        public void setNev(char szin)
        {
            this.nev = szin == 'W' ? "WK" : "BK";
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
