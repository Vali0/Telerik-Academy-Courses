namespace Company.Client
{
    using Company.Model;

    public abstract class DataGenerator : IDataGenerator
    {
        private CompanyDatabase db;
        private IRandomGenerator random;
        private int count;

        public DataGenerator(CompanyDatabase db, IRandomGenerator random, int count)
        {
            this.Db = db;
            this.Random = random;
            this.Count = count;
        }

        protected CompanyDatabase Db
        {
            get
            {
                return this.db;
            }
            private set
            {
                this.db = value;
            }
        }

        protected IRandomGenerator Random
        {
            get
            {
                return this.random;
            }
            private set
            {
                this.random = value;
            }
        }

        protected int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public abstract void GenerateData();
    }
}