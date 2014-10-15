using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01Portals
{
    class Program
    {
        static void Main(string[] args)
        {
            var startPositions = Console.ReadLine().Split();
            int startX = int.Parse(startPositions[0]);
            int startY = int.Parse(startPositions[1]);
            var cubeDimentions = Console.ReadLine().Split();
            int r = int.Parse(cubeDimentions[0]);
            int c = int.Parse(cubeDimentions[1]);

            var cube = new string[r, c];
            var used = new string[r, c];
            for (int x = 0; x < r; x++)
            {
                var line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int y = 0; y < c; y++)
                {
                    cube[x, y] = line[y];
                    if (line[y] == "#")
                    {
                        used[x, y] = line[y];
                    }
                }
            }

            var copy = used.Clone() as string[,];

            var startCell = new Cell(startX , startY, int.Parse(cube[startX, startY]));
            var queue = new Queue<Cell>();
            queue.Enqueue(startCell);
            int maxCount = 0;
            int counter = int.Parse(cube[startX, startY]);
            while (queue.Count > 0)
            {
                var currentCell = queue.Dequeue();
                
                used[currentCell.Row, currentCell.Column] = "#";
                maxCount = Math.Max(currentCell.Counter, maxCount);

                int teleportPower = int.Parse(cube[currentCell.Row, currentCell.Column]);

                // Left
                if (currentCell.Column - teleportPower >= 0)
                {
                    var newCell = new Cell(currentCell.Row, currentCell.Column - teleportPower, currentCell.Counter);
                    if (used[newCell.Row, newCell.Column] != "#")
                    {
                        newCell.Counter += int.Parse(cube[newCell.Row, newCell.Column]);
                        queue.Enqueue(newCell);
                        //used[newCell.Row, newCell.Column] = "#";
                    }
                }
                
                // Right
                if (currentCell.Column + teleportPower < c)
                {
                    var newCell = new Cell(currentCell.Row, currentCell.Column + teleportPower, currentCell.Counter);
                    if (used[newCell.Row, newCell.Column] != "#")
                    {
                        newCell.Counter += int.Parse(cube[newCell.Row, newCell.Column]);
                        queue.Enqueue(newCell);
                        //used[newCell.Row, newCell.Column] = "#";
                    }
                }

                // Up
                if (currentCell.Row - teleportPower >= 0)
                {
                    var newCell = new Cell(currentCell.Row - teleportPower, currentCell.Column, currentCell.Counter);
                    if (used[newCell.Row, newCell.Column] != "#")
                    {
                        newCell.Counter += int.Parse(cube[newCell.Row, newCell.Column]);
                        queue.Enqueue(newCell);
                        //used[newCell.Row, newCell.Column] = "#";
                    }
                }

                // Down
                if (currentCell.Row + teleportPower < r)
                {
                    var newCell = new Cell(currentCell.Row + teleportPower, currentCell.Column, currentCell.Counter);
                    if (used[newCell.Row, newCell.Column] != "#")
                    {
                        newCell.Counter += int.Parse(cube[newCell.Row, newCell.Column]);
                        queue.Enqueue(newCell);
                        //used[newCell.Row, newCell.Column] = "#";
                    }
                }
            }
            Console.WriteLine(maxCount);
        }
    }


    class Cell
    {
        public Cell(int row, int column, int counter)
        {
            this.Row = row;
            this.Column = column;
            this.Counter = counter;
        }

        public int Row { get; set; }

        public int Column { get; set; }

        public int Counter { get; set; }
    }
}