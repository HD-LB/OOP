namespace DocumentSystemMain.Models
{
    using System.Collections.Generic;

    using DocumentSystemMain.Interfaces;


    public abstract class BinaryDocument : Document, IDocument
    {
        //Constructor
        public BinaryDocument(string name, string content = null, int size = 0)
            : base(name, content)
        {
            this.Size = size;
        }

        //Proparty
        public int Size { get; private set; }


        //Methods
        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "size")
            {
                this.Size = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }            
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.Size != 0)
            {
                output.Add(new KeyValuePair<string, object>("size", this.Size));
                base.SaveAllProperties(output);
            }
        }
    }
}
