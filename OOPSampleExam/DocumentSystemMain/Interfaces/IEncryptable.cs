namespace DocumentSystemMain.Interfaces
{
    public interface IEncryptable
    {
        bool IsEncrypted { get; }
        void Encrypt();
        void Decrypt();
    }
}
