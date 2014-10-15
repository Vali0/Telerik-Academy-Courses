using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02CompanyArticles
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoCorp = new Company("Pesho Corp");

            peshoCorp.AddMillionArticles();

            peshoCorp.ShowArticlesInPriceRange(1234m, 4321m);
        }
    }
}
