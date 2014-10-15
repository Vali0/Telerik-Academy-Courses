using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Log4Net
{
    private static readonly ILog log = LogManager.GetLogger("TestLogger");

    static void Main()
    {
        BasicConfigurator.Configure();
        try
        {
            throw new InvalidOperationException("An exception occurred.");
        }
        catch (InvalidOperationException ex)
        {

            log.Error("Error-" + ex.Message);
        }
    }
}

