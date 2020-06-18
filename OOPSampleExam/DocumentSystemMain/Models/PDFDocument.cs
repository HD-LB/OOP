namespace DocumentSystemMain.Models
{
    using System.Collections.Generic;

    using DocumentSystemMain.Interfaces;

    public class PDFDocument : EncryptableDocument, IDocument, IEncryptable
    {
        //Constructor
        public PDFDocument(string name, string content = null, int size = 0, int numberOfPages = 0)
            : base(name, content, size)
        {
            this.NumberOfPages = numberOfPages;
        }

        //Proparty
        public int NumberOfPages { get; private set; }

        //Methods
        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "pages")
            {
                this.NumberOfPages = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.NumberOfPages != 0)
            {
                output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
                base.SaveAllProperties(output);
            }
        }        
    }
}
