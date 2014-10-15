using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task02CheckPerformanceOfValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();
            AddMethods.AddDecimal(4m, 500000m);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            AddMethods.AddDouble(4d, 500000d);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            AddMethods.AddFloat(4f, 500000f);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            AddMethods.AddInt(4, 500000);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            AddMethods.AddLong(4L, 500000L);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractDecimal(500000m, 4m);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractDouble(500000d, 4d);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractFloat(500000f, 4f);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractInt(500000, 4);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            SubstractMethods.SubstractLong(500000L, 4L);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyDecimal(2m, 500000m, 2m);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyDouble(2d, 500000d, 5d);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyFloat(2f, 500000f, 5f);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyInt(2, 500000, 5);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            MultiplyMethods.MultiplyLong(2L, 500000L, 5L);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            DivideMethods.DivideDecimal(500000m, 4m, 2m);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            DivideMethods.DivideDouble(500000d, 4d, 2d);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            DivideMethods.DivideFloat(500000f, 4f, 2f);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            DivideMethods.DivideInt(500000, 4, 2);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);

            timer.Reset();
            timer.Start();
            DivideMethods.DivideLong(500000L, 4L, 2L);
            Console.WriteLine(timer.Elapsed.TotalMilliseconds);
            timer.Stop();
        }
    }
}