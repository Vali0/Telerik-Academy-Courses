using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Model;

namespace Company.Client
{
    public class EmployeeDataGenerator : DataGenerator
    {
        public EmployeeDataGenerator(CompanyDatabase db, IRandomGenerator random, int count) : base(db, random, count)
        {
        }

        public override void GenerateData()
        {
            Console.WriteLine("Adding employees");

            var addedDepartments = this.Db.Departments.Select(x => x.DepartmentId).ToList();
            int? mangerId = null;

            for (int i = 0; i < this.Count; i++)
            {
                var addedEmployees = this.Db.Employees.Select(x => x.EmployeeId).ToList();
                if (addedEmployees.Count > 0)
                {
                    mangerId = addedEmployees[this.Random.GetRandomNumber(0, addedEmployees.Count - 1)];
                }

                var newEmployee = new Employee()
                {
                    FirstName = this.Random.GetRandomStringWithRandomLength(5, 20),
                    LastName = this.Random.GetRandomStringWithRandomLength(5, 20),
                    YearSalary = this.Random.GetRandomNumber(50000, 200000),
                    DepartmentId = addedDepartments[this.Random.GetRandomNumber(0, addedDepartments.Count - 1)],
                    ManagerId = this.Random.GetRandomNumber(0, 100) > 95 ? null : mangerId
                };

                this.Db.Employees.Add(newEmployee);

                if (i % 100 == 0)
                {
                    Console.Write('.');
                    this.Db.SaveChanges();
                }

                // To have different managers for first employees
                if (i == 7)
                {
                    this.Db.SaveChanges(); 
                }

               
            }

            Console.WriteLine("\nEmployees are added");
        }
    }
}