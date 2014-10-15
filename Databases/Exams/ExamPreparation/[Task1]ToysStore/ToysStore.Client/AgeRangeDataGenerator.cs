namespace ToysStore.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToysStore.Model;

    class AgeRangeDataGenerator : DataGenerator
    {
        public AgeRangeDataGenerator(ToysStoreEntities db, IRandomGenerator random, int count) : base(db, random, count)
        {
        }

        public override void GenerateData()
        {
            Console.WriteLine("Adding age ranges");
            for (int i = 0; i < this.Count; i++)
            {
                int minAge = this.Random.GetRandomNumber(2, 50);
                int maxAge = this.Random.GetRandomNumber(minAge, 60);

                var newAgeRange = new AgeRanx()
                {
                    MinimumAge = minAge,
                    MaximumAge = maxAge
                };

                this.Db.AgeRanges.Add(newAgeRange);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.Db.SaveChanges();
                }
            }
            Console.WriteLine("Added age ranges");
        }
    }
}