namespace Company.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Company.Model;

    class DepartmentDataGenerator : DataGenerator
    {
        public DepartmentDataGenerator(CompanyDatabase db, IRandomGenerator random, int count) : base (db, random, count)
        {
        }

        public override void GenerateData()
        {
            Console.WriteLine("Adding departments");

            var uniqueDepartments = new HashSet<string>();

            while (uniqueDepartments.Count != this.Count)
            {
                uniqueDepartments.Add(this.Random.GetRandomStringWithRandomLength(10, 50));
            }

            int index = 0;
            foreach (var departmentName in uniqueDepartments)
            {
                var newDepartment = new Department()
                {
                    Name = departmentName
                };
                this.Db.Departments.Add(newDepartment);

                if (index % 100 == 0)
                {
                    Console.Write('.');
                    this.Db.SaveChanges();
                }

                index++;
            }

            Console.WriteLine("\nDepartments are added");
        }
    }
}