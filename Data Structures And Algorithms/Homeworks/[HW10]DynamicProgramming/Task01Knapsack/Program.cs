using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01Knapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 10;
            var knapsack = new List<Product>();
            var all = new List<Product>();
            all.Add(new Product("beer", 3, 2));
            all.Add(new Product("vodka", 8, 12));
            all.Add(new Product("cheese", 4, 5));
            all.Add(new Product("nuts", 1, 4));
            all.Add(new Product("ham", 2, 3));
            all.Add(new Product("whiskey", 8, 13));

            var productsByValue = all.OrderByDescending(p => p.Price / p.Weight).ThenByDescending(p => p.Weight);
            foreach (var product in productsByValue)
            {
                if (knapsack.Sum(p => p.Weight) + product.Weight <= m)
                {
                    knapsack.Add(product);
                }
            }

            Console.WriteLine("Knapsack:\n" + string.Join(Environment.NewLine, knapsack));
            Console.WriteLine("Total: weight=" + knapsack.Sum(p => p.Weight) + ", cost=" + knapsack.Sum(p => p.Price));
        }
    }
}