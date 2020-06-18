namespace HTMLRenderer.Models
{
    using System;
    using HTMLRenderer.Interfaces;


    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new SimpleElement(name);
        }

        public IElement CreateElement(string name, string content)
        {
            return new SimpleElement(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new Table(rows, cols);
        }
    }
}
