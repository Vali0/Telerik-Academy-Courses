namespace Task02CompanyArticles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Article : IComparable
    {
        private string barcode;
        private string vendor;
        private decimal price;
        public Article(string barcode, string vendor, decimal price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Price = price;
        }

        public string Barcode
        {
            get
            {
                return this.barcode;
            }
            set
            {
                this.barcode = value;
            }
        }

        public string Vendor
        {
            get
            {
                return this.vendor;
            }
            set
            {
                this.vendor = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException("Referenced object is null");
            }

            if (!(obj is Article))
            {
                throw new ArgumentException("Referenced object is not of type article");
            }

            var otherArticle = obj as Article;

            return this.Price.CompareTo(otherArticle.Price);
        }
    }
}