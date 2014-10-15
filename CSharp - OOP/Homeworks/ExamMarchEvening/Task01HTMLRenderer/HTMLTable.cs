using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    class HTMLTable : HTMLElement, ITable
    {
        private int rows, cols;
        private IElement[,] cell;

        public int Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                this.cols = value;
            }
        }

        public HTMLTable(int rows, int cols) : base("table")
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cell = new IElement[Rows, Cols];
        }

        public IElement this[int row, int col]
        {
            get
            {
                return this.cell[row, col];
            }
            set
            {
                this.cell[row, col] = value;
            }
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>",this.Name);
            for (int i = 0; i < this.cell.GetLength(0); i++)
            {
                output.Append("<tr>");
                for (int j = 0; j < this.cell.GetLength(1); j++)
                {
                    output.AppendFormat("<td>{0}</td>", this.cell[i, j]);
                }
                output.Append("</tr>");
            }
            output.AppendFormat("</{0}>", this.Name);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            Render(result);
            return result.ToString();
        }
    }
}