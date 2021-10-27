using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFeladat
{
    public class Table
    {
        public int XHR = 8;
        public int YHR = 8;
        public List<Field> field = new List<Field>();

        private ConsoleColor defaultBColor;
        private ConsoleColor defaultTColor;

        public Table()
        {
            for (int x = 1; x <= XHR; x++)
            {
                for (int y = 1; y <= YHR; y++)
                {
                    field.Add(new Field(x, y));
                }
            }

            defaultBColor = Console.BackgroundColor;
            defaultTColor = Console.ForegroundColor;
        }
    }

    public void Draw(string error = null)
    {
        Console.Clear();
        Console.WriteLine("  A   B   C   D   E   F   G   H  ");
        Console.WriteLine("Y =================================");
        for (int x = 1; x <= XHR; x++)
        {
            Console.Write(x.ToString() + " |");
            for (int y = 1; y <= YHR; y++)
            {
                Field actualfield = Search(y, x);
                actualfield.Draw();
            }
        }
    }

    public Field Search(int x, int y)
    {
        foreach (Field item in field)
        {
            if (item.X == x && item.Y == y)
            {
                return item;
            }
        }

        return null;
    }


}
