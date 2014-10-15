namespace Matrix
{
    using System;

    public class Position
    {
        private int row, col;

        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Row can't be less than zero!");
                }
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cols can't be less than zero!");
                }
                this.col = value;
            }
        }

        public void Update(Delta delta)
        {
            this.Row += delta.Row;
            this.Col += delta.Col;
        }
    }
}