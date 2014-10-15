namespace Task01GetEmployeesFromTelerikDb
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TelerikAcademy.Data;

    class Program
    {
        static void Main(string[] args)
        {
            var db = new TelerikAcademyDatabase();
            var timer = new Stopwatch();
            TimeSpan[] takenTimes = new TimeSpan[3];
            db.Employees.Count();

            var employeesWithSelect = db.Employees.Select(x => new
            {
                x.FirstName,
                x.JobTitle,
                x.Salary,
                DepartmentName = x.Department.Name,
                Address = x.Address.AddressText,
                Town = x.Address.Town.Name
            });

            timer.Start();
            // With ordinary select
            foreach (var employee in db.Employees)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",
                    employee.FirstName, employee.JobTitle, employee.Salary, employee.Department.Name, employee.Address.AddressText, employee.Address.Town.Name);
            }
            
            timer.Stop();
            takenTimes[0] = timer.Elapsed;

            // With Include
            timer.Reset();
            timer.Start();
            foreach (var employee in db.Employees.Include("Departments"))
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",
                    employee.FirstName, employee.JobTitle, employee.Salary, employee.Department.Name, employee.Address.AddressText, employee.Address.Town.Name);
            }

            timer.Stop();
            takenTimes[1] = timer.Elapsed;
           
            timer.Reset();
            timer.Start();
            // With select
            foreach (var employee in employeesWithSelect)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}",
                    employee.FirstName, employee.JobTitle, employee.Salary, employee.DepartmentName, employee.Address, employee.Town);
            }

            timer.Stop();
            takenTimes[2] = timer.Elapsed;

            foreach (var item in takenTimes)
            {
                Console.WriteLine(item);
            }
        }
    }
}