namespace DocumentSystemMain.Models
{
    using System.Collections.Generic;

    using DocumentSystemMain.Interfaces;

    public abstract class MultimediaDocument : BinaryDocument, IDocument
    {
        //Constructor
        public MultimediaDocument(string name, string content = null, int size = 0, int lenght = 0)
            : base(name, content, size)
        {
            this.Lenght = lenght;
        }

        //Proparties
        public int Lenght { get; private set; }


        //Methods
        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "lenght")
            {
                this.Lenght = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (this.Lenght != 0)
            {
                output.Add(new KeyValuePair<string, object>("lenght", this.Lenght));
                base.SaveAllProperties(output);
            }
        }
    }
}
