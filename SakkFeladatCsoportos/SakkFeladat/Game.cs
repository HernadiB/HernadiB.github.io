using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakkFeladat
{
    public class Game
    {
        public Table GameTable;
        public Color Exit = Color.white;
        public bool end = false;
    }

    public Game()
    {
        GameTable = new Table();
    }
}
