namespace DocumentSystemMain.Models
{
    using System.Collections.Generic;

    using DocumentSystemMain.Interfaces;

    public class ExcelDocument : OfficeDocument, IDocument, IOfficeDocument, IEncryptable
    {
        //Constructor
        public ExcelDocument(string name, string content = null, int size = 0, string version = null, int numberOfColumns = 0, int numberOfRows = 0)
            : base(name, content, size, version)
        {
            this.NumberOfColumns = numberOfColumns;
            this.NumberOfRows = numberOfRows;
        }

        //Proparty
        public int NumberOfColumns { get; private set; }

        public int NumberOfRows { get; private set; }


        //Methods
        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "rows")
            {
                this.NumberOfRows = int.Parse(value);
            }
            else if (key.ToLower() == "cols")
            {
                this.NumberOfColumns = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.NumberOfRows != 0)
            {
                output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            }

            if (this.NumberOfColumns != 0)
            {
                output.Add(new KeyValuePair<string, object>("cols", this.NumberOfColumns));               
            }
             base.SaveAllProperties(output);
        }
    }
}
