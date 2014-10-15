namespace Minesweeper
{
    public class Points
    {
        private string name = string.Empty;
        private int score = 0;

        public Points()
        {
        }

        public Points(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                this.score = value;
            }
        }
    }
}