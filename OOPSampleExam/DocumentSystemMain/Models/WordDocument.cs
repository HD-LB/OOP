namespace DocumentSystemMain.Models
{
    using System.Collections.Generic;

    using DocumentSystemMain.Interfaces;

    public class WordDocument : OfficeDocument, IDocument, IOfficeDocument, IEncryptable, IEditable
    {
        //Constructor
        public WordDocument(string name, string content = null, int size = 0, string version = null, int numberOfCharacters = 0)
            : base(name, content, size, version)
        {
            this.NumberOfCharacters = numberOfCharacters;
        }

        //Proparty
        public int NumberOfCharacters { get; private set; }

        
        //Methods
        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "chars")
            {
                this.NumberOfCharacters = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }


        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.NumberOfCharacters != 0)
            {
                output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
                base.SaveAllProperties(output);
            }
        }
    }
}
