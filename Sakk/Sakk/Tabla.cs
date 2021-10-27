using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    public class Tabla
    {
        public int xMax = 8;
        public int yMax = 8;
        public List<Mezo> mezok = new List<Mezo>();

        private ConsoleColor alapHatterSzin;
        private ConsoleColor alapSzovegSzin;
        public Tabla() 
        {
            for (int x = 1; x <= xMax; x++)
            {
                for (int y = 1; y <= yMax; y++)
                {
                    mezok.Add(new Mezo(x, y));
                }
            }

            alapHatterSzin = Console.BackgroundColor;
            alapSzovegSzin = Console.ForegroundColor;
        }

        public void Kirajzol(string hibauzenet = null)
        {
            Console.Clear();
            Console.WriteLine("  X A   B   C   D   E   F   G   H  ");
            Console.WriteLine("Y =================================");
            for (int x = 1; x <= xMax; x++)
            {
                Console.Write(x.ToString() + " |");
                for (int y = 1; y <= yMax; y++)
                {
                    Mezo jelenlegiMezo = KeresKoordinataAlapjan(y, x);

                    jelenlegiMezo.Kirajzol();

                    Console.BackgroundColor = alapHatterSzin;
                    Console.ForegroundColor = alapSzovegSzin;

                    Console.Write("|");
                }
                Console.WriteLine("");
                Console.WriteLine("  =================================");
            }
            if (hibauzenet != null )
	        {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine(hibauzenet);
                Console.WriteLine("");
                Console.BackgroundColor = alapHatterSzin;
                Console.ForegroundColor = alapSzovegSzin;
	        }
        }

        public Mezo KeresKoordinataAlapjan(int x, int y)
        {
            foreach(Mezo mezo in mezok)
            {
                if(mezo.X == x && mezo.Y == y)
                {
                    return mezo;
                }
            }

            return null;
        }

        public void BabuAdasaMezohoz(Babu babu, int x, int y)
        {
            for (int i = 0; i < mezok.Count; i++)
            {
                if(mezok[i].X == x && mezok[i].Y == y)
                {
                    mezok[i].babu = babu;
                }
            }
        }

        public Babu BabuElvetelAMezobol(int x, int y) 
        {
            for (int i = 0; i < mezok.Count; i++)
			{
                if (mezok[i].X == x && mezok[i].Y == y && mezok[i].babu != null)
	            {
                    Babu result = mezok[i].babu;
                    mezok[i].babu = null;
                    return result;
	            }
			}
            return null;
        }
    }
}
