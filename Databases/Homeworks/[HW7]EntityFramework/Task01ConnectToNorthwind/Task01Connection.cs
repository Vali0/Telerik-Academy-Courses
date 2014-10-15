namespace Task01ConnectToNorthwind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Task01Connection
    {
        static void Main()
        {
            var dbContext = new NorthwindDatabase();
        }
    }
}