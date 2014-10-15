using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class PDFDocument : EncryptableDocument
    {
        public int? PageNumber { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "pages")
            {
                this.PageNumber = int.Parse(value);
            }
            base.LoadProperty(key, value);
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("pages", this.PageNumber));
            base.SaveAllProperties(output);
        }
    }
}