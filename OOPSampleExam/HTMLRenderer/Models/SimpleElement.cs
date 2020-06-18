namespace HTMLRenderer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using HTMLRenderer.Interfaces;


    public class SimpleElement : Element, ISimpleElement, IElement
    {
        //Fields
        private ICollection<IElement> childElements;

        //Constructor
        public SimpleElement(string name, string content = null)
            : base(name)
        {
            this.TextContent = content;
            this.childElements = new List<IElement>();

        }

        //Proparties
        public string TextContent { get; set; }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        //Methods
        public void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public override void Render(StringBuilder output)
        {
            string format = "{1}{2}";
            if (!string.IsNullOrEmpty(Name))
            {
                format = "<{0}>" + format + "</{0}>";
            }
            output.AppendFormat(format, this.Name, this.HTMLEncodeContent(this.TextContent), string.Join("", this.childElements));
        }

        private string HTMLEncodeContent(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                content = content
                     .Replace("&", "&amp")
                     .Replace("<", "&lt")
                     .Replace(">", "&gt");

            }

            return content;
        }
    }
}
