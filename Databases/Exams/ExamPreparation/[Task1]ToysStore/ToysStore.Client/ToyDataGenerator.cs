namespace ToysStore.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToysStore.Model;

    public class ToyDataGenerator : DataGenerator
    {
        public ToyDataGenerator(ToysStoreEntities db, IRandomGenerator random, int count) : base(db, random, count)
        {
        }

        public override void GenerateData()
        {
            var ageRangeIds = this.Db.AgeRanges.Select(a => a.Id).ToList();
            var categoryIds = this.Db.Categories.Select(c => c.Id).ToList();
            var manufacturerIds = this.Db.Manufacturers.Select(m => m.Id).ToList();

            Console.WriteLine("Adding toys");
            for (int i = 0; i < this.Count; i++)
            {
                string name = this.Random.GetRandomStringWithRandomLength(3, 60);
                string type = this.Random.GetRandomStringWithRandomLength(3, 20);
                decimal price = this.Random.GetRandomNumber(1, 1000);
                string color = this.Random.GetRandomStringWithRandomLength(3, 20);

                var newToy = new Toy()
                {
                    Name = name,
                    Type = type,
                    Price = price,
                    Color = this.Random.GetRandomNumber(1, 5) == 5 ? null : color,
                    ManufacturerId = manufacturerIds[this.Random.GetRandomNumber(1, manufacturerIds.Count - 1)],
                    AgeRangeId = ageRangeIds[this.Random.GetRandomNumber(1, ageRangeIds.Count - 1)]
                };

                if (categoryIds.Count > 0)
                {
                    var uniqueCategoryIds = new HashSet<int>();
                    var categoriesInToy = this.Random.GetRandomNumber(1, Math.Min(10, categoryIds.Count));

                    while (uniqueCategoryIds.Count != categoriesInToy)
                    {
                        uniqueCategoryIds.Add(categoryIds[this.Random.GetRandomNumber(1, categoryIds.Count - 1)]);
                    }

                    foreach (var uniqueCategoryId in uniqueCategoryIds)
                    {
                        newToy.Categories.Add(this.Db.Categories.Find(uniqueCategoryId));
                    }
                }

                this.Db.Toys.Add(newToy);
                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.Db.SaveChanges();
                }
            }
            Console.WriteLine("\nToys added");
        }
    }
}