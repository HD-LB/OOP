namespace HTMLRenderer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using HTMLRenderer.Interfaces;


    public abstract class Element : IElement
    {
        //Constructor
        public Element(string name)
        {
            this.Name = name;
        }

        //Proparties
        public string Name { get; private set; }

        //Methods
        public abstract void Render(StringBuilder output);

        public override string ToString()
        {
            var sb = new StringBuilder();
            this.Render(sb);

            return sb.ToString();
        }
    }
}
