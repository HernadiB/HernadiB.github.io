using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    class Bishop : ChessPiece, Piece
    {

        int osszesMozgas = 0;
        string nev;
        public Bishop(char szin) : base(szin)
        {
            setNev(szin);
        }
        public bool setMozgas(ChessPiece[,] tabla, int jelenOszlop, int jelenSor, int kovetkezoOszlop, int kovetkezoSor)
        {
            int jelenlegiMinuszKovetkezoOszlop = kovetkezoOszlop - jelenOszlop;
            int jelenlegiMinuszKovetkezoSor = kovetkezoSor - jelenSor;
            bool lehetsegesE = true;
            // ----------------------------------------------FEKETÉT ELLENŐRIZZÜK--------------------------------------
            if (jelenOszlop > kovetkezoOszlop && jelenSor > kovetkezoSor)
            {
                for (int i = jelenOszlop - 1, g = jelenSor - 1; lehetsegesE && i > kovetkezoOszlop && g > kovetkezoSor; i--, g--)
                {
                    if (!(tabla[i, g] is Blank))
                    {
                        lehetsegesE = false;
                    }
                }
            }
            if (jelenOszlop > kovetkezoOszlop && jelenSor < kovetkezoSor)
            {
                for (int i = jelenOszlop - 1, g = jelenSor + 1; lehetsegesE && i > kovetkezoOszlop && g < kovetkezoSor; i--, g++)
                {
                    if (!(tabla[i, g] is Blank))
                    {
                        lehetsegesE = false;
                    }
                }
            }
            //----------------------------------------------FEHÉRET ELLENŐRIZZÜK----------------------------
            if (jelenOszlop < kovetkezoOszlop && jelenSor < kovetkezoSor)
            {
                for (int i = jelenOszlop + 1, g = jelenSor + 1; lehetsegesE && i < kovetkezoOszlop && g < kovetkezoSor; i++, g++)
                {
                    if (!(tabla[i, g] is Blank))
                    {
                        lehetsegesE = false;
                    }
                }
            }
            if (jelenOszlop < kovetkezoOszlop && jelenSor > kovetkezoSor)
            {
                for (int i = jelenOszlop + 1, g = jelenSor - 1; lehetsegesE && i < kovetkezoOszlop && g > kovetkezoSor; i++, g--)
                {
                    if (!(tabla[i, g] is Blank))
                    {
                        lehetsegesE = false;
                    }
                }
            }
            if (lehetsegesE)
            {
                int atmenetiKovOszlop = jelenlegiMinuszKovetkezoOszlop > 0 ? jelenlegiMinuszKovetkezoOszlop : -(jelenlegiMinuszKovetkezoOszlop);
                int atmenetiKovSor = jelenlegiMinuszKovetkezoSor > 0 ? jelenlegiMinuszKovetkezoSor : -(jelenlegiMinuszKovetkezoSor);
                if (!(atmenetiKovOszlop == atmenetiKovSor))
                {
                    Console.WriteLine("A futó csak átlósan viszont akármennyit léphet egy irányba!");
                    lehetsegesE = false;
                    return lehetsegesE;
                }
            }

            if (!(lehetsegesE))
            {
                Console.WriteLine("A futó nem léphet át bábut!");
            }
            return lehetsegesE;
        }

        public void setNev(char szin)
        {
            this.nev = szin == 'W' ? "WB" : "BB";
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
