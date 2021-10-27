using System;
using SakkFelkesz.Entities;

namespace SakkFelkesz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write
               ("W-White(Fehér)\n" +
                "B-Black(Fekete)\n" +
                "P-Pawn(Gyalog)\n" +
                "N-Knight(Lovag)\n" +
                "R-Rook(Bástya)\n" +
                "Q-Queen(Királynő)\n" +
                "K-King(Király)\n");


            int mozgasok = 0;
            ChessPiece[,] tabla = { { new Rook('W'), new Knight('W'), new Bishop('W'), new Queen('W'), new King('W'), new Bishop('W'), new Knight('W'), new Rook('W')},
                                    { new Pawn('W'), new Pawn('W'), new Pawn('W'), new Pawn('W'), new Pawn('W'), new Pawn('W'), new Pawn('W'), new Pawn('W')},
                                    { new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '),},
                                    { new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '),},
                                    { new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '),},
                                    { new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '), new Blank(' '),},
                                    { new Pawn('B'), new Pawn('B'), new Pawn('B'), new Pawn('B'), new Pawn('B'), new Pawn('B'), new Pawn('B'), new Pawn('B'),},
                                    { new Rook('B'), new Knight('B'), new Bishop('B'), new Queen('B'), new King('B'), new Bishop('B'), new Knight('B'), new Rook('B'),}  };
            rajzolTabla(tabla);
            while (true)
            {

                string[] ervenyesE = kozetkezoMozgas(tabla, mozgasok);

                bool helyesDarabValasztva = kinekAKore(ervenyesE[1], mozgasok, tabla);
                if (helyesDarabValasztva)
                {
                    string[] Lehetseges = LehetsegesE(tabla, ervenyesE[1]);
                    if (Lehetseges[0] == "True")
                    {
                        ChessPiece[,] ujTabla = Mozog(tabla, Lehetseges[1], Lehetseges[2]);
                        mozgasok++;
                        if (ujTabla[0, 0] == null)
                        {
                            string nev = mozgasok % 2 != 0 ? "White" : "Black";
                            Console.WriteLine("{0} játékos nyert", nev);
                            return;
                        }
                        rajzolTabla(ujTabla);
                    }
                }
            }
        }

        static void rajzolTabla(ChessPiece[,] tabla)
        {
            Console.WriteLine("");
            Console.WriteLine("  A   B   C   D   E   F   G   H");
            Console.WriteLine(" --- --- --- --- --- --- --- --- ");
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int g = 0; g < tabla.GetLength(1); g++)
                {
                    Console.Write("|");
                    Console.Write(tabla[i, g] + " ");
                }
                Console.Write("|   " + (i + 1));
                Console.WriteLine("");
                Console.WriteLine(" --- --- --- --- --- --- --- --- ");
            }
            Console.WriteLine("");
        }
        static string[] kozetkezoMozgas(ChessPiece[,] tabla, int mozgasok)
        {
            bool helyesLepes = false;
            string valasztottLepes;
            char kiKovetkezik;
            string[] lista = new string[2];
            while (!helyesLepes)
            {
                if (mozgasok % 2 == 0)
                {
                    Console.WriteLine("Most a fehér köre következik\nMelyik bábut és hova mozgassuk?:(pl: 'A1A2')");
                    kiKovetkezik = 'W';
                }
                if (mozgasok % 2 != 0)
                {
                    Console.WriteLine("Most a fekete köre következik\nMelyik bábut és hova mozgassuk?:(pl: 'A1A2')");
                    kiKovetkezik = 'B';
                }
                valasztottLepes = Console.ReadLine();
                if (valasztottLepes == "")
                    Console.WriteLine("ENTER-t ütöttél érvényes számok nélkül");


                else if (valasztottLepes.Length != 4)
                    Console.WriteLine("A megadott lépés hiányos, add meg melyik bábut és hova mozgassuk!");

                else
                    helyesLepes = adatMegnez(valasztottLepes);

                lista[0] = helyesLepes + "";
                lista[1] = valasztottLepes;
            }
            return lista;
        }
        static bool adatMegnez(string adat)
        {
            string ellenorizBetuk = "" + adat[0] + adat[2];
            string ellenorizSzamok = "" + adat[1] + adat[3];
            ellenorizBetuk = ellenorizBetuk.ToUpper();
            string elerhetoBetuk = "ABCDEFGH";
            string elerhetoSzamok = "12345678";
            bool ervenyesBetu = false;
            bool ervenyesSzam = false;
            int szamolErvenyesBetuk = 0;
            int szamolErvenyesSzamok = 0;
            for (int i = 0; i < ellenorizBetuk.Length && !ervenyesBetu; i++)
            {
                for (int g = 0; g < elerhetoBetuk.Length && !ervenyesBetu; g++)
                {
                    if (ellenorizBetuk[i] == elerhetoBetuk[g])
                    {
                        szamolErvenyesBetuk++;
                        g = elerhetoBetuk.Length;
                    }
                }
            }

            for (int i = 0; i < ellenorizSzamok.Length && !ervenyesSzam; i++)
            {
                for (int g = 0; g < elerhetoSzamok.Length; g++)
                {
                    if (ellenorizSzamok[i] == elerhetoSzamok[g])
                    {
                        szamolErvenyesSzamok++;
                        g = elerhetoBetuk.Length;
                    }
                }
            }
            ervenyesBetu = szamolErvenyesBetuk == 2 ? true : false;
            ervenyesSzam = szamolErvenyesSzamok == 2 ? true : false;

            if (ervenyesSzam && ervenyesBetu)
                return true;
            if (!ervenyesBetu)
                Console.WriteLine("Érvénytelen betűt adtál meg!");
            if (!ervenyesSzam)
                Console.WriteLine("Érvénytelen számot adtál meg!");
            return false;
        }


        static bool kinekAKore(string valasztottLepes, int mozgas, ChessPiece[,] tabla)
        {
            bool kinekAKore = true;
            string mozgoDarab = "" + valasztottLepes[0] + valasztottLepes[1];
            char kiKovetkezik = mozgas % 2 == 0 ? 'W' : 'B';

            string helyezkedes = valtoztat(tabla, mozgoDarab);
            int oszlop = helyezkedes[0] - '0';
            int sor = helyezkedes[2] - '0';
            if (kiKovetkezik == 'B' && tabla[oszlop, sor].getSzin() == 'W')
            {
                Console.WriteLine("Egy fehér bábut választottál, de ez most a fekete köre!");
                kinekAKore = false;
            }
            if (kiKovetkezik == 'W' && tabla[oszlop, sor].getSzin() == 'B')
            {
                Console.WriteLine("Egy fekete bábut választottál, de ez most a fehér köre!");
                kinekAKore = false;
            }
            return kinekAKore;
        }

        static string[] LehetsegesE(ChessPiece[,] tabla, string valasztottLepes)
        {

            string mozgoDarab = "" + valasztottLepes[0] + valasztottLepes[1];
            string ideMozog = "" + valasztottLepes[2] + valasztottLepes[3];
            string darabHely = valtoztat(tabla, mozgoDarab);
            string ideMozogHely = valtoztat(tabla, ideMozog);
            bool megtudja = megtudjaCsinalniAMozgast(tabla, darabHely, ideMozogHely);

            string[] eredmeny = new string[3];
            eredmeny[0] = megtudja + "";
            eredmeny[1] = darabHely;
            eredmeny[2] = ideMozogHely;
            return eredmeny;
        }
        static bool megtudjaCsinalniAMozgast(ChessPiece[,] tabla, string darabHely, string ideMozogHely)
        {
            int darabHelyOszlop = darabHely[0] - '0';
            int darabHelySor = darabHely[2] - '0';

            int ideMozogHelyOszlop = ideMozogHely[0] - '0';
            int ideMozogHelySor = ideMozogHely[2] - '0';
            bool megtudja = false;

            if (tabla[darabHelyOszlop, darabHelySor] is Pawn)
                megtudja = ((Pawn)tabla[darabHelyOszlop, darabHelySor]).setMozgas(tabla, darabHelyOszlop, darabHelySor, ideMozogHelyOszlop, ideMozogHelySor);
            if (tabla[darabHelyOszlop, darabHelySor] is Blank)
                megtudja = ((Blank)tabla[darabHelyOszlop, darabHelySor]).setMozgas(tabla, darabHelyOszlop, darabHelySor, ideMozogHelyOszlop, ideMozogHelySor);
            if (tabla[darabHelyOszlop, darabHelySor] is Knight)
                megtudja = ((Knight)tabla[darabHelyOszlop, darabHelySor]).setMozgas(tabla, darabHelyOszlop, darabHelySor, ideMozogHelyOszlop, ideMozogHelySor);
            if (tabla[darabHelyOszlop, darabHelySor] is Rook)
                megtudja = ((Rook)tabla[darabHelyOszlop, darabHelySor]).setMozgas(tabla, darabHelyOszlop, darabHelySor, ideMozogHelyOszlop, ideMozogHelySor);
            if (tabla[darabHelyOszlop, darabHelySor] is Bishop)
                megtudja = ((Bishop)tabla[darabHelyOszlop, darabHelySor]).setMozgas(tabla, darabHelyOszlop, darabHelySor, ideMozogHelyOszlop, ideMozogHelySor);
            if (tabla[darabHelyOszlop, darabHelySor] is King)
                megtudja = ((King)tabla[darabHelyOszlop, darabHelySor]).setMozgas(tabla, darabHelyOszlop, darabHelySor, ideMozogHelyOszlop, ideMozogHelySor);
            if (tabla[darabHelyOszlop, darabHelySor] is Queen)
                megtudja = ((Queen)tabla[darabHelyOszlop, darabHelySor]).setMozgas(tabla, darabHelyOszlop, darabHelySor, ideMozogHelyOszlop, ideMozogHelySor);

            return megtudja;
        }
        static ChessPiece[,] Mozog(ChessPiece[,] tabla, string darabHely, string ideMozogHely)
        {
            int darabHelyOszlop = darabHely[0] - '0';
            int darabHelySor = darabHely[2] - '0';
            int oszlop = ideMozogHely[0] - '0';
            int sor = ideMozogHely[2] - '0';
            string osztalynev = tabla[darabHelyOszlop, darabHelySor].GetType().Name;
            ChessPiece helyezkedesMozgasElott = null;
            if (osztalynev == "Pawn")
                helyezkedesMozgasElott = (Pawn)tabla[darabHelyOszlop, darabHelySor];

            if (osztalynev == "Blank")
                helyezkedesMozgasElott = (Blank)tabla[darabHelyOszlop, darabHelySor];

            if (osztalynev == "Knight")
                helyezkedesMozgasElott = (Knight)tabla[darabHelyOszlop, darabHelySor];

            if (osztalynev == "Rook")
                helyezkedesMozgasElott = (Rook)tabla[darabHelyOszlop, darabHelySor];

            if (osztalynev == "Bishop")
                helyezkedesMozgasElott = (Bishop)tabla[darabHelyOszlop, darabHelySor];

            if (osztalynev == "King")
                helyezkedesMozgasElott = (King)tabla[darabHelyOszlop, darabHelySor];

            if (osztalynev == "Queen")
                helyezkedesMozgasElott = (Queen)tabla[darabHelyOszlop, darabHelySor];


            string osztalynev2 = tabla[oszlop, sor].GetType().Name;
            ChessPiece helyezkedesMozgasUtan = null;
            if (osztalynev2 == "Pawn")
                helyezkedesMozgasUtan = (Pawn)tabla[oszlop, sor];

            else if (osztalynev2 == "Blank")
                helyezkedesMozgasUtan = (Blank)tabla[oszlop, sor];

            else if (osztalynev2 == "Knight")
                helyezkedesMozgasUtan = (Knight)tabla[oszlop, sor];

            else if (osztalynev2 == "Rook")
                helyezkedesMozgasUtan = (Rook)tabla[oszlop, sor];

            else if (osztalynev2 == "Bishop")
                helyezkedesMozgasUtan = (Bishop)tabla[oszlop, sor];

            else if (osztalynev2 == "King")
                helyezkedesMozgasUtan = (King)tabla[oszlop, sor];

            else if (osztalynev2 == "Queen")
                helyezkedesMozgasUtan = (Queen)tabla[oszlop, sor];

            if (tabla[oszlop, sor] is Blank)
                tabla[darabHelyOszlop, darabHelySor] = helyezkedesMozgasUtan;

            else if (osztalynev == "King" && tabla[darabHelyOszlop, darabHelySor].getSzin() == tabla[oszlop, sor].getSzin() && osztalynev2 == "Rook")
            {
                tabla[darabHelyOszlop, darabHelySor] = helyezkedesMozgasUtan;
            }

            else
            {
                Console.WriteLine("Leütötted a(z) ellenfél " + tabla[oszlop, sor].GetType().Name + "-(e)t");
                tabla[darabHelyOszlop, darabHelySor] = new Blank(' ');
                if (tabla[oszlop, sor].GetType().Name == "King")
                {
                    tabla[0, 0] = null;
                }
            }
            tabla[oszlop, sor] = helyezkedesMozgasElott;


            return tabla;
        }

        static string valtoztat(ChessPiece[,] tabla, string ideMozog)
        {
            string str = ideMozog.ToUpper();
            int oszlop = (char)str[1] - '0';
            int sor = 0;
            switch ((char)str[0])
            {
                case 'A':
                    sor = 0;
                    break;
                case 'B':
                    sor = 1;
                    break;
                case 'C':
                    sor = 2;
                    break;
                case 'D':
                    sor = 3;
                    break;
                case 'E':
                    sor = 4;
                    break;
                case 'F':
                    sor = 5;
                    break;
                case 'G':
                    sor = 6;
                    break;
                case 'H':
                    sor = 7;
                    break;
                default:
                    Console.WriteLine("HIBA");
                    break;
            }
            string ideMozogHely = "" + (oszlop - 1) + "|" + sor;
            return ideMozogHely;
        }
    }
}
