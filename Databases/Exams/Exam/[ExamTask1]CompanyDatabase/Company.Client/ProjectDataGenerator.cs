using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Model;

namespace Company.Client
{
    public class ProjectDataGenerator : DataGenerator
    {
        public ProjectDataGenerator(CompanyDatabase db, IRandomGenerator random, int count) : base(db, random, count)
        {
        }

        public override void GenerateData()
        {
            Console.WriteLine("Adding projects");

            for (int i = 0; i < this.Count; i++)
            {
                var allEmployeesInDb = this.Db.Employees.ToList();
                var numberOfEmployees = this.Random.GetRandomNumber(2, 20);
                var uniqueEmployees = new HashSet<Employee>();

                while (uniqueEmployees.Count != numberOfEmployees)
                {
                    uniqueEmployees.Add(allEmployeesInDb[this.Random.GetRandomNumber(0, allEmployeesInDb.Count - 1)]);
                }

                var randomYear = this.Random.GetRandomNumber(2000, 2020);
                var randomMonth = this.Random.GetRandomNumber(1, 12);
                var randomDay = this.Random.GetRandomNumber(1, 28);

                var startDate = new DateTime(randomYear, randomMonth, randomDay);
                var endDate = new DateTime(randomYear, randomMonth, randomDay).AddDays(this.Random.GetRandomNumber(1, 360));

                var newProject = new Project()
                {
                    Name = this.Random.GetRandomStringWithRandomLength(5, 50),
                    StartDate = startDate,
                    EndDate = endDate,
                    Employees = uniqueEmployees
                };
                
                this.Db.Projects.Add(newProject);

                if (i % 100 == 0)
                {
                    Console.Write('.');
                    this.Db.SaveChanges();
                }
            }

            Console.WriteLine("\nProjects are added");
        }
    }
}