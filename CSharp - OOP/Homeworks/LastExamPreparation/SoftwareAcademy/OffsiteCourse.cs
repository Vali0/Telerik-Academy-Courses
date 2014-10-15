using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    class OffsiteCourse : Course, IOffsiteCourse
    {
        public string Town { get; set; }

        public OffsiteCourse(string name, ITeacher teacher, string town) : base(name, teacher)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            if (this.Town != null)
            {
                result.AppendFormat("; Town={0}", this.Town);
            }
            return result.ToString();
        }
    }
}