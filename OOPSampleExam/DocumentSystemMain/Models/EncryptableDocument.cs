namespace DocumentSystemMain.Models
{
    using DocumentSystemMain.Interfaces;

    public abstract class EncryptableDocument : BinaryDocument, IDocument, IEncryptable
    {
        //Constructor
        public EncryptableDocument(string name, string content = null, int size = 0)
           : base(name, content, size)
        {
            this.IsEncrypted = false;
        }

        //Proparties
        public bool IsEncrypted { get; private set; }

        //Methods
        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {
                return string.Format("{0}[encrypted]", this.GetType().Name);
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
;