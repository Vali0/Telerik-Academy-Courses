namespace Task02SelectPerformance
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
            db.Employees.Count();
            var timer = new Stopwatch();

            timer.Start();
            var slowSelect = db.Employees.ToList()
                .Select(a => a.Address).ToList()
                .Select(t => t.Town).ToList()
                .Where(t => t.Name == "Sofia");
            Console.WriteLine("Slow select: " + timer.Elapsed);

            timer.Reset();
            timer.Start();
            var fastSelect = db.Employees.Select(x => new
            {
                x.FirstName,
                x.Address.AddressText,
                TownName = x.Address.Town.Name
            }).Where(y => y.TownName == "Sofia");

            Console.WriteLine("Fast select: " + timer.Elapsed);
        }
    }
}