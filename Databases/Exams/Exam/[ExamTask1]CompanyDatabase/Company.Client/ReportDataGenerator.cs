using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Model;

namespace Company.Client
{
    public class ReportDataGenerator : DataGenerator
    {

        public ReportDataGenerator(CompanyDatabase db, IRandomGenerator random, int count) : base(db, random, count)
        {
        }

        public override void GenerateData()
        {
            Console.WriteLine("Adding reports. This may take a while... wow 250 000 reports");

            var savedEmployees = this.Db.Employees.ToList();

            foreach (var employee in savedEmployees)
            {
                for (int i = 0; i < 50; i++)
                {
                    var newReport = new Report(){
                        Date = new DateTime(this.Random.GetRandomNumber(2000,2020), this.Random.GetRandomNumber(1,12), this.Random.GetRandomNumber(1,28)),
                        Employee = employee
                    };

                    this.Db.Reports.Add(newReport);
                }

                Console.Write('.');
                this.Db.SaveChanges();
            }

            Console.WriteLine("\nReports are added");
        }
    }
}