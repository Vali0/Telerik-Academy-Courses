using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Task02FindProductsInPriceRange
{
    class Program
    {
        private static Random randomizer = new Random();
        private const int MaxPrice = 10000;

        static void Main(string[] args)
        {
            var products = new OrderedBag<Product>();

            for (int i = 0; i < 500000; i++)
            {
                products.Add(new Product("Product No:" + i, (decimal)(randomizer.NextDouble() * MaxPrice)));
            }

            decimal fromPrice = 0m;
            decimal toPrice = 0m;
            for (int i = 0; i < 10000; i++)
            {
                fromPrice = (decimal)(randomizer.NextDouble() * 100);
                toPrice = (decimal)(randomizer.NextDouble() * 110);
                if (toPrice < fromPrice)
                {
                    decimal tempPrice = toPrice;
                    toPrice = fromPrice;
                    fromPrice = tempPrice;
                }

                var productsInPriceRange = products.Range(new Product("from", fromPrice), true, new Product("to", toPrice), true);
                Console.WriteLine("---Products in price range {0} - {1}---", fromPrice, toPrice);
                foreach (var item in productsInPriceRange)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}