using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14Labyrinth
{
    class Cell
    {
        public int Row { get; set; }

        public int Col { get; set; }

        public int Distance { get; set; }

        public Cell(int row, int col, int distance)
        {
            this.Row = row;
            this.Col = col;
            this.Distance = distance;
        }
    }
}