namespace DocumentSystemMain
{
    using System.Collections.Generic;

    using DocumentSystemMain.Interfaces;

    public class TextDocument : Document, IDocument, IEditable
    {
        //Constructor   
        public TextDocument(string name, string charset = null)
            : base (name)
        {
            this.Charset = charset;
        }

        //Proparty
        public string Charset { get; private set; }

        //Methods
        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }            
        }

         public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.Charset != null)
            {
                output.Add(new KeyValuePair<string, object>("charset", this.Charset));
                base.SaveAllProperties(output);
            }
        }
    }
}
