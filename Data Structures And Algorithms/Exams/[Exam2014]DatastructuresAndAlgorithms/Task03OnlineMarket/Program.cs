using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Task03OnlineMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var onlineMarket = new Product();
            string line = "";
            StringBuilder output = new StringBuilder();

            do
            {
                line = Console.ReadLine();
                var tokens = line.Split(' ');
                if (tokens[0] == "add")
                {
                    string name = tokens[1];
                    double price = double.Parse(tokens[2]);
                    string productType = tokens[3];
                    //if ((name.Length >= 3 && name.Length <= 20) && (price > 0 && price <= 5000) && (productType.Length >= 3 && productType.Length <= 20))
                    {
                        var result = onlineMarket.Add(name, price, productType);
                        output.AppendLine(result);
                    }
                }
                else if (tokens[0] == "filter")
                {
                    var result = new List<Product>();

                    if (tokens[2] == "type")
                    {
                        result = onlineMarket.FilterByType(tokens[3]);
                        if (result.Count == 0)
                        {
                            output.AppendFormat("Error: Type {0} does not exists", tokens[3]);
                        }
                        else
                        {
                            output.Append("Ok: ");
                        }
                    }
                    else if (tokens[2] == "price")
                    {
                        output.Append("Ok: ");
                        if (tokens[3] == "from")
                        {
                            if (tokens.Length > 5 && tokens[5] == "to")
                            {
                                double fromPrice = double.Parse(tokens[4]);
                                double toPrice = double.Parse(tokens[6]);
                                if (fromPrice < toPrice)
                                {
                                    result = onlineMarket.FilterByFromToPrice(fromPrice, toPrice);
                                }
                                else
                                {
                                    result = onlineMarket.FilterByFromToPrice(toPrice, fromPrice);
                                }
                            }
                            else
                            {
                                result = onlineMarket.FilterFromPrice(double.Parse(tokens[4]));
                            }
                        }
                        else
                        {
                            result = onlineMarket.FilterToPrice(double.Parse(tokens[4]));
                        }
                    }

                    if (result.Count() > 0)
                    {
                        //    result = result.OrderBy(x => x.Price).ThenBy(x => x.ProductName).ThenBy(x => x.ProductType).ToList();
                        foreach (var item in result)
                        {
                            output.AppendFormat("{0}, ", item);
                        }

                        output.Length -= 2;
                    }
                    output.AppendLine();
                }
            }
            while (line != "end");

            Console.WriteLine(output.ToString());
        }
    }

    public class Product
    {
        //private List<Product> products = new List<Product>();
        //private BigList<Product> products = new BigList<Product>();
        //private OrderedBag<Product> products = new OrderedBag<Product>();
        private Bag<string> names = new Bag<string>();
        //private Dictionary<string, Product> products = new Dictionary<string, Product>();
        private HashSet<Product> products = new HashSet<Product>();

        public string ProductName { get; set; }

        public double Price { get; set; }

        public string ProductType { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                return this.ProductName.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {
            Product temp = obj as Product;
            if (temp == null)
                return false;
            return this.Equals(temp);
        }

        private int ProductsCount
        {
            get
            {
                if (this.products.Count < 10)
                {
                    return this.products.Count;
                }

                return 10;
            }
        }

        public string Add(string name, double price, string type)
        {
            if (this.names.Contains(name))
            //if (this.products.ContainsKey(name))
            {
                return string.Format("Error: Product {0} already exists", name);
            }

            this.names.Add(name);
            var product = new Product()
            {
                ProductName = name,
                Price = price,
                ProductType = type
            };
            this.products.Add(product);

            return string.Format("Ok: Product {0} added successfully", product.ProductName);
        }

        public List<Product> FilterByType(string type)
        {

            var filtered = this.products.Where(x => x.ProductType == type).OrderBy(x => x.Price).ThenBy(x => x.ProductName)
                .ThenBy(x => x.ProductType).Take(this.ProductsCount).ToList();
            //var filtered = this.products.Where(x => x.Value.ProductType == type).Take(this.ProductsCount).Select(x => x.Value).ToList();

            return filtered;
        }

        public List<Product> FilterByFromToPrice(double fromPrice, double toPrice)
        {
            var filtered = this.products.Where(x => x.Price >= fromPrice && x.Price <= toPrice).OrderBy(x => x.Price)
                .ThenBy(x => x.ProductName).ThenBy(x => x.ProductType).Take(this.ProductsCount).ToList();
            //var filtered = this.products.Where(x => x.Value.Price >= fromPrice && x.Value.Price <= toPrice).Take(this.ProductsCount).Select(x => x.Value).ToList();

            return filtered;
        }

        public List<Product> FilterFromPrice(double fromPrice)
        {
            var filtered = this.products.Where(x => x.Price >= fromPrice).OrderBy(x => x.Price)
                .ThenBy(x => x.ProductName).ThenBy(x => x.ProductType).Take(this.ProductsCount).ToList();
            //var filtered = this.products.Where(x => x.Value.Price >= fromPrice).Take(this.ProductsCount).Select(x => x.Value).ToList();

            return filtered;
        }

        public List<Product> FilterToPrice(double toPrice)
        {
            var filtered = this.products.Where(x => x.Price <= toPrice).OrderBy(x => x.Price)
                .ThenBy(x => x.ProductName).ThenBy(x => x.ProductType).Take(this.ProductsCount).ToList();
            //var filtered = this.products.Where(x => x.Value.Price <= toPrice).Take(this.ProductsCount).Select(x => x.Value).ToList();

            return filtered;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}({1})", this.ProductName, this.Price);

            return result.ToString();
        }

        //public int CompareTo(Product other)
        //{
        //    if (this.Price.CompareTo(other.Price) == 0)
        //    {
        //        if (this.ProductName.CompareTo(other.ProductName) == 0)
        //        {
        //            return this.ProductType.CompareTo(other.ProductType);
        //        }
        //        else
        //        {
        //            return this.ProductName.CompareTo(other.ProductName);
        //        }
        //    }
        //    return this.Price.CompareTo(other.Price);
        //}
    }
}