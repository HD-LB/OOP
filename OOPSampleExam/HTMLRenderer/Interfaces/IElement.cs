namespace HTMLRenderer.Interfaces
{
    using System;
    using System.Text;

    public interface IElement
    {
        string Name { get; }        
        void Render(StringBuilder output);
        string ToString();

    }
}
