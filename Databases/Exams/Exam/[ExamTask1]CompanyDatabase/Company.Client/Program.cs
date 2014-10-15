using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Model;

namespace Company.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfDepartments = 100;
            const int NumberOfEmployees = 5000;
            const int NumberOfProjects = 1000;
            const int NumberOfReports = 250000;

            var random = RandomGenerator.Instance;
            var db = new CompanyDatabase();
            db.Configuration.AutoDetectChangesEnabled = false;

            var dataGenerators = new List<IDataGenerator>()
            {
                new DepartmentDataGenerator(db, random, NumberOfDepartments),
                new EmployeeDataGenerator(db, random, NumberOfEmployees),
                new ProjectDataGenerator(db, random, NumberOfProjects),
                new ReportDataGenerator(db, random, NumberOfReports)
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