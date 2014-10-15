namespace ToysStore.Client
{
    using System;
    using System.Linq;
    using ToysStore.Model;

    public class CategoryDataGenerator : DataGenerator
    {
        public CategoryDataGenerator(ToysStoreEntities db, IRandomGenerator random, int count) : base(db, random, count)
        {
        }
        
        public override void GenerateData()
        {
            Console.WriteLine("Adding categories");
            for (int i = 0; i < this.Count; i++)
            {
                var newCategory = new Category()
                {
                    Name = this.Random.GetRandomStringWithRandomLength(4, 100)
                };

                this.Db.Categories.Add(newCategory);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.Db.SaveChanges();
                }
            }
            Console.WriteLine("Added categories");
        }
    }
}