namespace Matrix
{
    using System;
    using System.Text;
    
    public class Matrix
    {
        public const int MaxSize = 10;
        private static readonly Delta[] deltas;
        private readonly int[,] matrix;

        static Matrix()
        {
            int directionsCount = Delta.DirectionsCount;
            deltas = new Delta[directionsCount];

            for (int i = 0; i < directionsCount; i++)
            {
                deltas[i] = new Delta((Direction)i);
            }
        }

        public Matrix(int size)
        {
            if (size < 1 || size > MaxSize)
            {
                throw new ArgumentOutOfRangeException(
                    "size",
                    string.Format("Size must be in the range between 1 and {0}.", MaxSize));
            }

            this.matrix = new int[size, size];
        }

        public void Traverse()
        {
            this.Clear();

            int counter = 1;
            Position position = new Position(0, 0);
            Delta delta = new Delta(Direction.Southeast);

            while (true)
            {
                this.matrix[position.Row, position.Col] = counter;

                if (!this.CanContinue(position))
                {
                    bool newPositionFound = this.TryFindNewPosition(out position);
                    if (newPositionFound)
                    {
                        counter++;
                        this.matrix[position.Row, position.Col] = counter;
                        delta.Direction = Direction.Southeast;
                    }
                    else
                    {
                        break;
                    }
                }

                while (!this.CanGoToPosition(position.Row + delta.Row, position.Col + delta.Col))
                {
                    delta.UpdateDirectionClockwise();
                }

                position.Update(delta);
                counter++;
            }
        }

        private void Clear()
        {
            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    this.matrix[row, col] = 0;
                }
            }
        }

        private bool CanGoToPosition(int row, int col)
        {
            bool validRow = 0 <= row && row < this.matrix.GetLength(0);
            bool validCol = 0 <= col && col < this.matrix.GetLength(1);

            return validRow && validCol && this.matrix[row, col] == 0;
        }

        private bool CanContinue(Position position)
        {
            for (int i = 0; i < deltas.Length; i++)
            {
                if (this.CanGoToPosition(position.Row + deltas[i].Row, position.Col + deltas[i].Col))
                {
                    return true;
                }
            }

            return false;
        }

        private bool TryFindNewPosition(out Position newPosition)
        {
            newPosition = new Position(0, 0);

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    if (this.matrix[row, col] == 0)
                    {
                        newPosition.Row = row;
                        newPosition.Col = col;
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    result.AppendFormat("{0}{1}", matrix[row, col], new string(' ',
                        ((this.matrix.GetLength(0) * this.matrix.GetLength(1)).ToString().Length) - matrix[row, col].ToString().Length + 1));
                }

                result.Append(Environment.NewLine);
            }
            result.Length -= 3;
            return result.ToString();
        }
    }
}