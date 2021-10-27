using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFelkesz.Entities
{
    class Queen : ChessPiece, Piece
    {
        string nev;
        int osszesMozgas;
        public Queen(char szin) : base(szin)
        {
            setNev(szin);
        }
        public int getOsszesMozgas()
        {
            return osszesMozgas;
        }

        public bool setMozgas(ChessPiece[,] tabla, int jelenOszlop, int jelenSor, int kovetkezoOszlop, int kovetkezoSor)
        {
            int jelenlegiMinuszKovetkezoOszlop = kovetkezoOszlop - jelenOszlop;
            int jelenlegiMinuszKovetkezoSor = kovetkezoSor - jelenSor;
            bool lehetsegesE = true;
            bool atlosan = false;
            bool jobbBal = false;
            bool felLe = false;
            char szin = this.getSzin();

            if (!atlosan)
            {
                int atmenetiKovOszlop = jelenlegiMinuszKovetkezoOszlop > 0 ? jelenlegiMinuszKovetkezoOszlop : -(jelenlegiMinuszKovetkezoOszlop);
                int atmenetiKovSor = jelenlegiMinuszKovetkezoSor > 0 ? jelenlegiMinuszKovetkezoSor : -(jelenlegiMinuszKovetkezoSor);
                if (atmenetiKovOszlop == atmenetiKovSor)
                {
                    atlosan = true;
                }
            }
            if (!jobbBal)
            {
                if (jelenlegiMinuszKovetkezoOszlop == 0)
                {
                    jobbBal = true;
                }
            }
            if (!felLe)
            {
                if (jelenlegiMinuszKovetkezoSor == 0)
                {
                    felLe = true;
                }
            }
            if (!atlosan && !jobbBal && !felLe)
            {
                Console.WriteLine("A királynő csak átlósa, balra, jobbra vagy fel és le mozoghat!");
                lehetsegesE = false;
                return lehetsegesE;
            }

            if (tabla[kovetkezoOszlop, kovetkezoSor].getSzin() == this.getSzin())
            {
                Console.WriteLine("Nem mozoghat a királynő olyan mezőre ahol saját bábu áll!");
                return false;
            }
            if (szin == 'B')
            {
                if (atlosan)
                {
                    if (jelenOszlop > kovetkezoOszlop && jelenSor < kovetkezoSor)
                    {
                        for (int i = jelenOszlop - 1, g = jelenSor + 1; lehetsegesE && i > kovetkezoOszlop && g < jelenSor; i--, g++)
                        {
                            if (!(tabla[i, g] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                    if (jelenOszlop > kovetkezoOszlop && jelenSor > kovetkezoSor)
                    {
                        for (int i = jelenOszlop - 1, g = jelenSor - 1; lehetsegesE && i > kovetkezoOszlop && g > kovetkezoSor; i--, g--)
                        {
                            if (!(tabla[i, g] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                }
                if (jobbBal)
                {
                    if (jelenSor < kovetkezoSor && jelenlegiMinuszKovetkezoOszlop == 0)
                    {
                        for (int i = jelenSor + 1; lehetsegesE && i < kovetkezoSor; i++)
                        {
                            if (!(tabla[jelenOszlop, i] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
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
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                }
                if (felLe)
                {
                    if (jelenOszlop < kovetkezoOszlop && jelenlegiMinuszKovetkezoSor == 0)
                    {
                        for (int i = jelenOszlop + 1; lehetsegesE && i < kovetkezoOszlop; i++)
                        {
                            if (!(tabla[i, jelenSor] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                    if (jelenOszlop > kovetkezoOszlop && jelenlegiMinuszKovetkezoSor == 0)
                    {
                        for (int i = jelenOszlop - 1; lehetsegesE && i > kovetkezoOszlop; i--)
                        {
                            if (!(tabla[i, jelenSor] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                }
            }
            if (szin == 'W')
            {
                if (atlosan)
                {
                    if (jelenOszlop < kovetkezoOszlop && jelenSor < kovetkezoSor)
                    {
                        for (int i = jelenOszlop + 1, g = jelenSor + 1; i < kovetkezoOszlop && g < jelenSor; i++, g++)
                        {
                            if (!(tabla[i, g] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                    if (jelenOszlop < kovetkezoOszlop && jelenSor > kovetkezoSor)
                    {
                        for (int i = jelenOszlop + 1, g = jelenSor - 1; !atlosan && i < kovetkezoOszlop && g > kovetkezoSor; i++, g--)
                        {
                            if (!(tabla[i, g] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                }
                if (jobbBal)
                {
                    if (jelenSor < kovetkezoSor && jelenlegiMinuszKovetkezoOszlop == 0)
                    {
                        for (int i = jelenSor + 1; lehetsegesE && i < kovetkezoSor; i++)
                        {
                            if (!(tabla[jelenOszlop, i] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
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
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                }
                if (felLe)
                {
                    if (jelenOszlop < kovetkezoOszlop && jelenlegiMinuszKovetkezoSor == 0)
                    {
                        for (int i = jelenOszlop + 1; lehetsegesE && i < kovetkezoOszlop; i++)
                        {
                            if (!(tabla[i, jelenSor] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                    if (jelenOszlop > kovetkezoOszlop && jelenlegiMinuszKovetkezoSor == 0)
                    {
                        for (int i = jelenOszlop - 1; lehetsegesE && i > kovetkezoOszlop; i--)
                        {
                            if (!(tabla[i, jelenSor] is Blank))
                            {
                                Console.WriteLine("A királynő nem léphet át más bábukat!");
                                lehetsegesE = false;
                            }
                        }
                    }
                }
            }
            if (lehetsegesE)
                osszesMozgas++;
            return lehetsegesE;
        }

        public void setNev(char szin)
        {
            this.nev = szin == 'W' ? "WQ" : "BQ";
        }
        public override string ToString()
        {
            return nev;
        }
    }

}
