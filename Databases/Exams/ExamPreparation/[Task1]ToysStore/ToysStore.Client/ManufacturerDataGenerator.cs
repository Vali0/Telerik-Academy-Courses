namespace ToysStore.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToysStore.Model;

    public class ManufacturerDataGenerator : DataGenerator
    {
        public ManufacturerDataGenerator(ToysStoreEntities db, IRandomGenerator random, int count) : base(db, random, count)
        {
        }

        public override void GenerateData()
        {
            Console.WriteLine("Adding manufacturers");

            var uniqueManufacturers = new HashSet<string>();

            while (uniqueManufacturers.Count != this.Count)
            {
                uniqueManufacturers.Add(this.Random.GetRandomStringWithRandomLength(3, 20));
            }

            int index = 0;
            foreach (var manufacturerName in uniqueManufacturers)
            {
                var country = this.Random.GetRandomStringWithRandomLength(2, 50);
                var newManufacturer = new Manufacturer()
                {
                    Name = manufacturerName,
                    Country = country
                };

                this.Db.Manufacturers.Add(newManufacturer);

                if (index % 100 == 0)
                {
                    Console.Write(".");
                    this.Db.SaveChanges();
                }
                index++;
            }
            Console.WriteLine("Added manufacturers");
        }
    }
}