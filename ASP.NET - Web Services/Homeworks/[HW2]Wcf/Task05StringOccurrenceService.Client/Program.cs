using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task04StringOccurrenceService.Client.StringOccurrenceService;

namespace Task04StringOccurrenceService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start task03 for service :)
            var client = new StringCounterClient();
            int numberOfAppears = client.CountHowMuchTimesStringApersInOtherString("Lorem ipsum is lorem and ipsum is lorem and so on lorem.", "lorem");
            Console.WriteLine(numberOfAppears);
        }
    }
}
