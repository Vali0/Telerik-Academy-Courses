namespace ATM.Data
{
    using ATM.Data.Migrations;
    using ATM.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AtmDatabase : DbContext
    {
        // Your context has been configured to use a 'AtmDatabase' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ATM.Data.AtmDatabase' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AtmDatabase' 
        // connection string in the application configuration file.
        public AtmDatabase() : base("name=AtmDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AtmDatabase, Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<CardAccount> CardAccounts { get; set; }

        public DbSet<TransactHistory> TransactionsHistory { get; set; }
    }
}