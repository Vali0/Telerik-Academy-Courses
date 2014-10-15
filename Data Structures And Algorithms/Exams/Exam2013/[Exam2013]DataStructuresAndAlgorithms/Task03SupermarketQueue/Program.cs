using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Task03SupermarketQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var supermarket = new SupermarketQueue();
            StringBuilder result = new StringBuilder();
            string line = "";
            do
            {
                line = Console.ReadLine();
                var tokens = line.Split(' ');
                if (tokens[0] == "Append")
                {
                    supermarket.Append(tokens[1]);
                    result.AppendLine("OK");
                }
                else if (tokens[0] == "Insert")
                {
                    try
                    {
                        supermarket.Insert(int.Parse(tokens[1]), tokens[2]);
                        result.AppendLine("OK");
                    }
                    catch (Exception e)
                    {
                        result.AppendLine("Error");
                    }
                }
                else if (tokens[0] == "Find")
                {
                    int count = supermarket.Find(tokens[1]);
                    result.AppendLine(count.ToString());
                }
                else if (tokens[0] == "Serve")
                {
                    try
                    {
                        var servedPeople = supermarket.Serve(int.Parse(tokens[1]));

                        for (int i = 0; i < servedPeople.Count; i++)
                        {
                            if (i != servedPeople.Count - 1)
                            {
                                result.AppendFormat("{0} ", servedPeople[i]);
                            }
                            else
                            {
                                result.AppendLine(servedPeople[i]);
                            }
                        }
                        
                    }
                    catch (Exception e)
                    {
                        result.AppendLine("Error");
                    }
                }
            }
            while (line != "End");

            Console.WriteLine(result.ToString().Trim());
        }
    }

    class SupermarketQueue
    {
        private BigList<string> queue = new BigList<string>();
        private Bag<string> names = new Bag<string>();

        public void Append(string name)
        {
            this.queue.Add(name);
            this.names.Add(name);
        }

        public void Insert(int position, string name)
        {
            this.queue.Insert(position, name);
            this.names.Add(name);
        }

        public int Find(string name)
        {
            int count = this.names.NumberOfCopies(name);

            return count;
        }

        public BigList<string> Serve(int count)
        {
            var serverdPeople = this.queue.GetRange(0, count);
            this.queue.RemoveRange(0, count);
            this.names.RemoveMany(serverdPeople);

            return serverdPeople;
        }
    }
}