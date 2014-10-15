using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    class HTMLTable : HTMLElement, ITable
    {
        public int Rows { get; private set; }

        public int Cols { get; private set; }

        private IElement[,] cell;

        public HTMLTable(int rows, int cols) : base("table")
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cell = new IElement[rows, cols];
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
            output.Append("<table>");
            for (int i = 0; i < this.cell.GetLength(0); i++)
            {
                output.Append("<tr>");
                for (int j = 0; j < this.cell.GetLength(1); j++)
                {
                    output.AppendFormat("<td>{0}</td>", this.cell[i, j]);
                }
                output.Append("</tr>");
            }
            output.Append("</table>");
        }
        
    }
}