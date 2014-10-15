using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02DayOfWeekInBulgarian.Client.DayOfWeekInBulgarianService;

namespace Task02DayOfWeekInBulgarian.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            var dayOfWeek = new DayOfWeekServiceClient();
            Console.WriteLine(dayOfWeek.GetDayOfWeekAsync(DateTime.Now).Result);
        }
    }
}
