using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02FindProductsInPriceRange
{
    class Product : IComparable
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

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

        public override string ToString()
        {
            return string.Format("{0} price: {1}", this.Name, this.Price);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Compared product is null");
            }

            if (!(obj is Product))
            {
                throw new ArgumentException("Referenced object is not of type Product");
            }

            var otherProduct = obj as Product;

            return this.Price.CompareTo(otherProduct.Price);
        }
    }
}
