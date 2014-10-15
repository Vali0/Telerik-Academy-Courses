using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            var startPositions = Console.ReadLine().Split(' ');
            var labyrinthDimentions = Console.ReadLine().Split(' ');
            int l = int.Parse(labyrinthDimentions[0]);
            int r = int.Parse(labyrinthDimentions[1]);
            int c = int.Parse(labyrinthDimentions[2]);

            var startCell = new Cell(int.Parse(startPositions[0]),
                int.Parse(startPositions[1]), int.Parse(startPositions[2]), 1);

            var labyrinth = new char[l, r, c];
            var used = new char[l, r, c];
            for (int x = 0; x < l; x++)
            {
                for (int y = 0; y < r; y++)
                {
                    var line = Console.ReadLine();
                    for (int z = 0; z < c; z++)
                    {
                        labyrinth[x, y, z] = line[z];
                        if (line[z] == '#')
                        {
                            used[x, y, z] = line[z];
                        }
                    }
                }
            }

            var queue = new Queue<Cell>();
            queue.Enqueue(startCell);

            while (queue.Count > 0)
            {
                var currentCell = queue.Dequeue();

                // Left
                if (currentCell.Column > 0)
                {
                    var newCell = new Cell(currentCell.Level, currentCell.Row, currentCell.Column - 1, currentCell.Counter + 1);
                    if (used[newCell.Level, newCell.Row, newCell.Column] != '#')
                    {
                        queue.Enqueue(newCell);
                        used[newCell.Level, newCell.Row, newCell.Column] = '#';
                    }
                }

                // Right
                if (currentCell.Column < c - 1)
                {
                    var newCell = new Cell(currentCell.Level, currentCell.Row, currentCell.Column + 1, currentCell.Counter + 1);
                    if (used[newCell.Level, newCell.Row, newCell.Column] != '#')
                    {
                        queue.Enqueue(newCell);
                        used[newCell.Level, newCell.Row, newCell.Column] = '#';
                    }
                }

                // Up
                if (currentCell.Row > 0)
                {
                    var newCell = new Cell(currentCell.Level, currentCell.Row - 1, currentCell.Column, currentCell.Counter + 1);
                    if (used[newCell.Level, newCell.Row, newCell.Column] != '#')
                    {
                        queue.Enqueue(newCell);
                        used[newCell.Level, newCell.Row, newCell.Column] = '#';
                    }
                }

                // Down
                if (currentCell.Row < r - 1)
                {
                    var newCell = new Cell(currentCell.Level, currentCell.Row + 1, currentCell.Column, currentCell.Counter + 1);
                    if (used[newCell.Level, newCell.Row, newCell.Column] != '#')
                    {
                        queue.Enqueue(newCell);
                        used[newCell.Level, newCell.Row, newCell.Column] = '#';
                    }
                }

                //Next floor
                if (labyrinth[currentCell.Level, currentCell.Row, currentCell.Column] == 'D')
                {
                    if (currentCell.Level > 0)
                    {
                        var newCell = new Cell(currentCell.Level - 1, currentCell.Row, currentCell.Column, currentCell.Counter + 1);
                        if (used[newCell.Level, newCell.Row, newCell.Column] != '#')
                        {
                            queue.Enqueue(newCell);
                            used[newCell.Level, newCell.Row, newCell.Column] = '#';
                        }
                    }
                    else
                    {
                        Console.WriteLine(currentCell.Counter);
                        return;
                    }
                }

                // Previous floor
                if (labyrinth[currentCell.Level, currentCell.Row, currentCell.Column] == 'U')
                {
                    if (currentCell.Level < l - 1)
                    {
                        var newCell = new Cell(currentCell.Level + 1, currentCell.Row, currentCell.Column, currentCell.Counter + 1);
                        if (used[newCell.Level, newCell.Row, newCell.Column] != '#')
                        {
                            queue.Enqueue(newCell);
                            used[newCell.Level, newCell.Row, newCell.Column] = '#';
                        }
                    }
                    else
                    {
                        Console.WriteLine(currentCell.Counter);
                        return;
                    }
                }
            }
        }
    }

    class Cell
    {
        public Cell(int level, int row, int column, int counter)
        {
            this.Level = level;
            this.Row = row;
            this.Column = column;
            this.Counter = counter;
        }
        
        public int Level { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }

        public int Counter { get; set; }
    }
}