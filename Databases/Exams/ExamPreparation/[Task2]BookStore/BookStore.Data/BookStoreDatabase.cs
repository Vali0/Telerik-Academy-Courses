namespace BookStore.Data
{
    using BookStore.Data.Migrations;
    using BookStore.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BookStoreDatabase : DbContext
    {
        public BookStoreDatabase() : base("name=BookStoreDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookStoreDatabase, Configuration>());
        }

        public virtual IDbSet<Author> Authors { get; set; }

        public virtual IDbSet<Book> Books { get; set; }

        public virtual IDbSet<Review> Reviews { get; set; }
    }
}