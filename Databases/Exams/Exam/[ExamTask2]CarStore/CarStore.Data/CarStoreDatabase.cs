namespace CarStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CarStore.Model;
    using CarStore.Data.Migrations;

    public class CarStoreDatabase : DbContext
    {
        // Your context has been configured to use a 'CarStoreDatabase' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CarStore.Data.CarStoreDatabase' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CarStoreDatabase' 
        // connection string in the application configuration file.
        public CarStoreDatabase() : base("name=CarStoreDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarStoreDatabase, Configuration>());
        }

        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<City> Cities { get; set; }

        public virtual IDbSet<Dealer> Dealers { get; set; }

        public virtual IDbSet<Manufacturer> Manufacturers { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}