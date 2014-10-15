namespace ToysStore.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ToysStore.Model;

    class Program
    {
        static void Main(string[] args)
        {
            var random = RandomGenerator.Instance;
            var db = new ToysStoreEntities();
            db.Configuration.AutoDetectChangesEnabled = false;

            var dataGenerators = new List<IDataGenerator>()
            {
                new CategoryDataGenerator(db, random, 100),
                new ManufacturerDataGenerator(db, random, 50),
                new AgeRangeDataGenerator(db, random, 100),
                new ToyDataGenerator(db, random, 20000)
            };

            foreach (var dataGenerator in dataGenerators)
            {
                dataGenerator.GenerateData();
                db.SaveChanges();
            }

            db.Configuration.AutoDetectChangesEnabled = true;
        }
    }
}