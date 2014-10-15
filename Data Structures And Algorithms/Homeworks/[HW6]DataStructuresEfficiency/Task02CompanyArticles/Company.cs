namespace Task02CompanyArticles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class Company
    {
        private string name;
        private readonly OrderedMultiDictionary<decimal, Article> articles;

        public Company(string name)
        {
            this.Name = name;
            this.articles = new OrderedMultiDictionary<decimal, Article>(false);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public void AddMillionArticles()
        {
            for (int i = 0; i < 1000000; i++)
            {
                var article = new Article("abcd" + i,"ArticleN" + i, (i + 1)/3.5m);
                this.articles.Add(article.Price, article);
            }
        }

        public void ShowArticlesInPriceRange(decimal fromPrice, decimal toPrice)
        {
            var articlesInPriceRange = this.articles.Range(fromPrice, true, toPrice, true);

            foreach (var article in articlesInPriceRange)
            {
                foreach (var item in article.Value)
                {
                    Console.WriteLine("{0} -> {1}", item.Vendor, item.Price);
                }
            }
        }
    }
}