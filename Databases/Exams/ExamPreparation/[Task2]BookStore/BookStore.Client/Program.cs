namespace BookStore.Client
{
    using BookStore.Data;
    using BookStore.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var db = new BookStoreDatabase();
            db.Configuration.AutoDetectChangesEnabled = false;
            //ImportDataToSqlFromXml(db, "complex-books.xml");
            GenerateXmlReviewByQuery(db);
        }

        private static void GenerateXmlReviewByQuery(BookStoreDatabase db)
        {
            var xmlElements = XElement.Load("reviews-queries.xml");
            var xmlSearchResult = new XElement("search-results");

            foreach (var xmlElement in xmlElements.Elements())
            {
                var listOfReviews = db.Reviews.AsQueryable();
                if (xmlElement.Attribute("type").Value == "by-period")
                {
                    var startDate = DateTime.Parse(xmlElement.Element("start-date").Value);
                    var endDate = DateTime.Parse(xmlElement.Element("end-date").Value);

                    listOfReviews = listOfReviews.Where(x => x.CreatedOn >= startDate && x.CreatedOn <= endDate);
                }
                else if (xmlElement.Attribute("type").Value == "by-author")
                {
                    var authorName = xmlElement.Element("author-name").Value;

                    listOfReviews = listOfReviews.Where(x => x.Author.Name == authorName);
                }

                var resultSet = listOfReviews.OrderBy(x => x.CreatedOn)
                                             .ThenBy(x => x.Content)
                                             .Select(x => new
                                             {
                                                 Date = x.CreatedOn,
                                                 Content = x.Content,
                                                 Book = new
                                                 {
                                                     Title = x.Book.Title,
                                                     Authors = x.Book
                                                                .Authors
                                                                .OrderBy(y => y.Name),
                                                     ISBN = x.Book.Isbn,
                                                     WebSite = x.Book.WebSite
                                                 }
                                             })
                                             .ToList();

                var xmlReview = new XElement("result-set");
                foreach (var reviewItem in resultSet)
                {
                    var review = new XElement("review");
                    review.Add(new XElement("date", reviewItem.Date.ToString("d-MMM-yyyy")));
                    review.Add(new XElement("content", reviewItem.Content));
                    var book = new XElement("book");
                    book.Add(new XElement("title", reviewItem.Book.Title));

                    if (reviewItem.Book.Authors.Count() > 0)
                    {
                        var authors = new XElement("authors", string.Join(", ", reviewItem.Book.Authors.Select(x => x.Name)));
                        book.Add(authors);
                    }

                    if (reviewItem.Book.ISBN != null)
                    {
                        book.Add(new XElement("isbn", reviewItem.Book.ISBN));
                    }
                    book.Add(new XElement("url", reviewItem.Book.WebSite));

                    review.Add(book);
                    xmlReview.Add(review);
                }

                xmlSearchResult.Add(xmlReview);
            }

            xmlSearchResult.Save("reviews-search-results.xml");
        }

        private static void ImportDataToSqlFromXml(BookStoreDatabase db, string path)
        {
            var xmlElements = XElement.Load(path);

            foreach (var xmlELement in xmlElements.Elements())
            {
                var currentBook = new Book();
                currentBook.Title = xmlELement.Element("title").Value.Trim();

                var authors = xmlELement.Element("authors");
                if (authors != null)
                {
                    foreach (var author in authors.Elements())
                    {
                        var currentAuthor = db.Authors.FirstOrDefault(x => x.Name == author.Value);
                        if (currentAuthor == null)
                        {
                            currentAuthor = new Author()
                            {
                                Name = author.Value
                            };
                        }

                        currentBook.Authors.Add(currentAuthor);
                    }
                }

                var webSite = xmlELement.Element("web-site");
                if (webSite != null)
                {
                    currentBook.WebSite = webSite.Value;
                }

                var reviews = xmlELement.Element("reviews");
                if (reviews != null)
                {
                    foreach (var review in reviews.Elements())
                    {
                        var currentReview = new Review();
                        currentReview.Content = review.Value.Trim();
                        var reviewAuthorName = review.Attribute("author");
                        if (reviewAuthorName != null)
                        {
                            var reviewAuthor = db.Authors.FirstOrDefault(a => a.Name == reviewAuthorName.Value);
                            if (reviewAuthor == null)
                            {
                                reviewAuthor = new Author()
                                {
                                    Name = reviewAuthorName.Value
                                };
                            }

                            currentReview.Author = reviewAuthor;
                        }

                        var createdDate = review.Attribute("date");
                        if (createdDate != null)
                        {
                            currentReview.CreatedOn = DateTime.Parse(createdDate.Value);
                        }
                        else
                        {
                            currentReview.CreatedOn = DateTime.Now;
                        }

                        currentBook.Reviews.Add(currentReview);
                    }
                }

                var isbn = xmlELement.Element("isbn");
                if (isbn != null)
                {
                    currentBook.Isbn = isbn.Value;
                }

                var price = xmlELement.Element("price");
                if (price != null)
                {
                    currentBook.Price = decimal.Parse(price.Value);
                }

                db.Books.Add(currentBook);
                db.SaveChanges();
            }
        }
    }
}