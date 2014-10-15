using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    class HTMLElement : IElement
    {
        private string name, textContent;
        private IList<IElement> childElements;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string TextContent
        {
            get
            {
                return this.textContent;
            }
            set
            {
                this.textContent = value;
            }
        }

        public HTMLElement(string name) : this(name,null)
        {
        }

        public HTMLElement(string name, string textContent)
        {
            this.Name = name;
            this.TextContent = textContent;
            childElements = new List<IElement>();
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public void AddElement(IElement element)
        {
            childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.AppendFormat("<{0}>", this.Name);
            }
            if (this.TextContent != null)
            {
                foreach (var item in TextContent)
                {
                    switch(item)
                    {
                        case '<' :
                            {
                                output.Append("&lt;");
                                break;
                            }
                        case '>':
                            {
                                output.Append("&gt;");
                                break;
                            }
                        case '&' :
                            {
                                output.Append("&amp;");
                                break;
                            }
                        default:
                            {
                                output.Append(item);
                                break;
                            }
                    }
                }
            }

            if (this.childElements.Count > 0)
            {
                foreach (var item in ChildElements)
                {
                    output.Append(item);
                }
            }
            if (this.Name != null)
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            Render(result);
            return result.ToString();
        }
    }
}