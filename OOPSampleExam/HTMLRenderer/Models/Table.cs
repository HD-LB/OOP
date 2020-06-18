namespace HTMLRenderer.Models
{
    using System;
    using System.Text;
    using HTMLRenderer.Interfaces;

    public class Table : Element, ITable, IElement
    {
        //Fields
        private const string tableName = "table";
        private IElement[,] matrix;

        //Constructor
        public Table(int rows, int cols)
            :base(tableName)
        {
            this.matrix = new IElement[rows, cols];
        }

        //Proparties
        public IElement this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public int Rows { get; private set; }

        public int Cols { get; private set; }


        //Methods
        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", base.Name);
            for (int r = 0; r < this.matrix.GetLength(0); r++)
            {
                output.Append("<tr>");
                for (int c = 0; c < this.matrix.GetLength(1); c++)
                {
                    output.AppendFormat("<td>{0}</td>", this.matrix[r, c]);
                }

                output.Append("</tr>");
            }

            output.AppendFormat("</{0}>", base.Name);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
