using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Task05ShoppingCenter
{
    class Program
    {
        static BigList<Product> products = new BigList<Product>();

        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();
                int indexOfInterval = line.IndexOf(' ');
                string command = line.Substring(0, indexOfInterval);
                string parameters = line.Substring(indexOfInterval + 1);
                var tokens = parameters.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (command == "AddProduct")
                {
                    var newProduct = new Product(tokens[0], float.Parse(tokens[1]), tokens[2]);
                    result.Append(Add(newProduct));
                }
                else if (command == "DeleteProducts")
                {
                    if (tokens.Length == 1)
                    {
                        result.AppendLine(DeleteProductByProducer(parameters));
                    }
                    else
                    {
                        result.AppendLine(DeleteProductByNameAndProducer(tokens[0], tokens[1]));
                    }
                }
                else if (command == "FindProductsByName")
                {
                    result.Append(FindProductByName(tokens[0]));
                }
                else if (command == "FindProductsByPriceRange")
                {
                    if(float.Parse(tokens[0]) <= float.Parse(tokens[1]))
                    {
                    result.Append(FindProductByPriceRange(float.Parse(tokens[0]), float.Parse(tokens[1])));
                    }
                    else
                    {
                        result.Append(FindProductByPriceRange(float.Parse(tokens[1]), float.Parse(tokens[0])));
                    }
                }
                else if (command == "FindProductsByProducer")
                {
                    result.Append(FindProductByProducer(tokens[0]));
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }

        static string Add(Product product)
        {
            products.Add(product);
            return "Product added\n";
        }

        static string DeleteProductByNameAndProducer(string name, string producer)
        {
            int oldProductsCount = products.Count;
            products.RemoveAll(x => x.Name == name && x.Producer == producer);
            int newProductsCount = products.Count;
            int deletedProducts = oldProductsCount - newProductsCount;

            if (deletedProducts == 0)
            {
                return "No products found";
            }

            return string.Format("{0} products deleted", deletedProducts);
        }

        static string DeleteProductByProducer(string producer)
        {
            int oldProductsCount = products.Count;
            products.RemoveAll(x => x.Producer == producer);
            int newProductsCount = products.Count;
            int deletedProducts = oldProductsCount - newProductsCount;

            if (deletedProducts == 0)
            {
                return "No products found";
            }

            return string.Format("{0} products deleted", deletedProducts);
        }

        static string FindProductByName(string name)
        {
            var filteredProducts = products.FindAll(x => x.Name == name).OrderBy(x => x.Name).ThenBy(x => x.Producer);

            StringBuilder result = new StringBuilder();
            foreach (var product in filteredProducts)
            {
                result.Append(product.ToString());
            }

            if (string.IsNullOrWhiteSpace(result.ToString()))
            {
                return "No products found\n";
            }

            return result.ToString();
        }

        static string FindProductByProducer(string producer)
        {
            var filteredProducts = products.FindAll(x => x.Producer == producer).OrderBy(x => x.Name).ThenBy(x => x.Producer);

            StringBuilder result = new StringBuilder();
            foreach (var product in filteredProducts)
            {
                result.Append(product.ToString());
            }

            if (string.IsNullOrWhiteSpace(result.ToString()))
            {
                return "No products found\n";
            }

            return result.ToString();
        }

        static string FindProductByPriceRange(float fromPrice, float toPrice)
        {
            var filteredProducts = products.FindAll(x => x.Price >= fromPrice && x.Price <= toPrice).OrderBy(x => x.Name).ThenBy(x => x.Producer);

            StringBuilder result = new StringBuilder();
            foreach (var product in filteredProducts)
            {
                result.Append(product.ToString());
            }

            if (string.IsNullOrWhiteSpace(result.ToString()))
            {
                return "No products found\n";
            }

            return result.ToString();
        }
    }

    class Product
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public string Producer { get; set; }

        public Product(string name, float price, string producer)
        {
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append('{');
            result.AppendFormat("{0};{1};{2:0.00}", this.Name, this.Producer, this.Price);
            result.AppendLine("}");

            return result.ToString();
        }
    }
}