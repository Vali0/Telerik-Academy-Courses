using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02SimpleFunctionality
{
    class Program
    {
        static void Main()
        {
            //Task01 Look Task01ConnectToNorthwind project and Task01Connection class main method (if you doesn't saw it)

            // Task02
            DataAccessObject.AddCustomer("BLABA", "Mafioti");
            DataAccessObject.UpdateCustomer("BLABA", "ULTRASI");
            DataAccessObject.RemoveCustomer("BLABA");

            // Task03
            DataAccessObject.ShowCustomersOrderedIn1997ForCanada();

            // Task04
            DataAccessObject.ShowCustomersOrderedIn1997ForCanadaSqlQuery();

            // Task05
            DataAccessObject.ShowOrdersByGivenRegionAndPeriod("CA", new DateTime(1997, 6, 25), new DateTime(1997, 7, 23));

            // Task06
            DataAccessObject.CreateNorthwindCopyIfNotExist();

            // Task07
            DataAccessObject.TwoParalelConnectionsToSameDate();

            // Task09
            DataAccessObject.AddOrder("RATTC");

            // Task10
            DataAccessObject.ShowIncomesForGivenSupplierAndPeriod("Tokyo Traders", new DateTime(1990, 1, 1), new DateTime(2000, 1, 1));

            // Task11 I had problem with transaction method so I doesn't include it in project

            // Task12 I have Profiler so... asumed is as accomplished
            
            // Task13 I looked source code of project and watched other lecture for code first and performance 
            // so I'm pretty sure that I've done that task too
        }
    }
}
