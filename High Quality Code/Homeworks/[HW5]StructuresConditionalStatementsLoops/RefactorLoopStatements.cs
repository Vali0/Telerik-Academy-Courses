namespace Task03RefactorLoopStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Refactor the following loop: 
    class RefactorLoopStatements
    {
        public static void RefactorLoopStatements()
        {
            bool foundValue = false;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0 && array[i] == searchedValue)
                {
                    foundValue = true; // Or print "Value Found" and break the loop. But I tried to use example from the presentation
                    break;
                }
            }

            // More code here
            if (foundValue)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}