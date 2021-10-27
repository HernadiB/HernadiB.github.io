using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    class Pawn : ChessPiece, Piece
    {

        int osszesMozgas = 0;
        string nev;
        public Pawn(char szin) : base(szin)
        {
            setNev(szin);
        }
        public void setNev(char szin)
        {
            this.nev = szin == 'W' ? "WP" : "BP";
        }
        public bool setMozgas(ChessPiece[,] tabla, int jelenOszlop, int jelenSor, int kovetkezoOszlop, int kovetkezoSor)
        {
            char jelenlegiSzin = this.getSzin();
            int jelenlegiMinuszKovetkezoOszlop = kovetkezoOszlop - jelenOszlop;
            int jelenlegiMinuszKovetkezoSor = kovetkezoSor - jelenSor;
            if (jelenlegiMinuszKovetkezoSor != 0 && (jelenlegiMinuszKovetkezoSor == -1 || jelenlegiMinuszKovetkezoSor == 1) && (jelenlegiMinuszKovetkezoOszlop == -1 || jelenlegiMinuszKovetkezoOszlop == 1))
            {
                if (tabla[kovetkezoOszlop, kovetkezoSor] is Blank)
                {
                    Console.WriteLine("A gyalog csak abba az irányba tud leütni, más esetben csak előre halad!");
                    return false;
                }
                else { osszesMozgas++; return true; }

            }
            else if (osszesMozgas > 0 && (jelenlegiMinuszKovetkezoSor > 1 || jelenlegiMinuszKovetkezoSor < -1 || jelenlegiMinuszKovetkezoOszlop > 1 || jelenlegiMinuszKovetkezoOszlop < -1))
            {
                Console.WriteLine("A gyalog csak átlósan és csak egy egységben tudja leütni ellenfelét!");
                return false;
            }
            if (osszesMozgas == 0)
            {
                if (jelenOszlop > kovetkezoOszlop)
                {
                    bool babuBlokkol = false;
                    for (int i = jelenOszlop - 1; !babuBlokkol && i >= kovetkezoOszlop; i--)
                    {
                        if (!(tabla[i, jelenSor] is Blank))
                        {
                            babuBlokkol = true;
                            Console.WriteLine("Útban van egy másik bábu így oda nem lehet lépni!");
                            return false;
                        }
                    }
                }
                if (jelenOszlop < kovetkezoOszlop)
                {
                    bool babuBlokkol = false;
                    for (int i = jelenOszlop + 1; !babuBlokkol && i <= kovetkezoOszlop; i++)
                    {
                        if (!(tabla[i, jelenSor] is Blank))
                        {
                            babuBlokkol = true;
                            Console.WriteLine("Útban van egy másik bábu így oda nem lehet lépni!");
                            return false;
                        }
                    }
                }
                if (jelenlegiSzin == 'W')
                    if (jelenlegiMinuszKovetkezoSor == 0 && (jelenlegiMinuszKovetkezoOszlop == 1 || jelenlegiMinuszKovetkezoOszlop == 2))
                    {
                        osszesMozgas++;
                        return true;
                    }
                if (jelenlegiSzin == 'B')
                    if (jelenlegiMinuszKovetkezoSor == 0 && (jelenlegiMinuszKovetkezoOszlop == -1 || jelenlegiMinuszKovetkezoOszlop == -2))
                    {
                        osszesMozgas++;
                        return true;
                    }
            }
            if (osszesMozgas > 0)
            {
                if (!(tabla[kovetkezoOszlop, kovetkezoSor] is Blank))
                {
                    Console.WriteLine("Érvénytelen lépés, egy másik bábu útban van!");
                    return false;
                }
                if (jelenlegiSzin == 'W')
                    if (jelenlegiMinuszKovetkezoOszlop == 1 && jelenlegiMinuszKovetkezoSor == 0)
                    {
                        osszesMozgas++;
                        return true;
                    }
                if (jelenlegiSzin == 'B')
                    if (jelenlegiMinuszKovetkezoOszlop == -1 && jelenlegiMinuszKovetkezoSor == 0)
                    {
                        osszesMozgas++;
                        return true;
                    }
            }
            if (osszesMozgas == 0)
                Console.WriteLine("A gyalog az első körben 1 vagy 2 lépést tehet előre!");
            if (osszesMozgas > 0)
                Console.WriteLine("A gyalog egy lépést tehet előre!");
            return false;

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
