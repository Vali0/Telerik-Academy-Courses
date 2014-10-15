using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    abstract class Document : IDocument
    {
        public string Name { get; private set; }

        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.GetType().Name);
            IList<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();
            SaveAllProperties(properties);
            var sortedProperties = properties.OrderBy(item => item.Key);
            result.Append("[");
            foreach (var item in sortedProperties)
            {
                if(item.Value!=null)
                {
                    result.AppendFormat("{0}={1};", item.Key, item.Value);
                }
            }
            result.Length--;
            result.Append("]");

            return result.ToString();
        }
    }
}