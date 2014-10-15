using System;

class GSMTest
{
    static void Main(string[] args)
    {
        Battery battery = new Battery("BL35", 5, 4, BatteryType.NiCd); // Generating battery type
        Display display = new Display(11.9f,65); // Generating display type

        GSM[] phoneStore = new GSM[3]; // Array for instances

        // Defining few instances
        GSM firstPhone = new GSM("6120c", "Nokia", 320, "Vali0",battery,display); 
        GSM secondPhone = new GSM("ChinaPhone", "China", 20,battery);
        GSM thirdPhone = new GSM("unknown", "Neverland", 9999, "YOU", battery);

        // Put them into the array
        phoneStore[0] = firstPhone;
        phoneStore[1] = secondPhone;
        phoneStore[2] = thirdPhone;

        // Print gsm information using overrided ToString() method
        foreach (GSM item in phoneStore)
        {
            Console.WriteLine(item.ToString());
        }
        
        // Printing the static iPhone
        Console.WriteLine("Ugly iPhone");
        Console.WriteLine(GSM.IPhone4S.Model);
        Console.WriteLine(GSM.IPhone4S.Manufacturer);
        Console.WriteLine(GSM.IPhone4S.Price);
        Console.WriteLine(GSM.IPhone4S.Owner);
        // can't parse constructors to static fields thats why there is no battery and displey specifications

        // Adding few calls
        // Uncomment following Sleep lines if you want different times at the output
        // Because the processor is fast and generate this instances really fast, they have same time (probably)
        firstPhone.AddCall(DateTime.Now, "0876123456", 123);
        //System.Threading.Thread.Sleep(500);
        firstPhone.AddCall(DateTime.Now, "0850981234", 666);
        firstPhone.AddCall(DateTime.Now, "0883504390", 985);
        //System.Threading.Thread.Sleep(1000);
        firstPhone.AddCall(DateTime.Now, "0986091234", 11);
        //System.Threading.Thread.Sleep(2000);
        firstPhone.AddCall(DateTime.Now, "0888800888", 23);

        firstPhone.DisplayHistory();
        Console.WriteLine("Price of calls: " + firstPhone.CalculatePrice(0.37m));

        firstPhone.DeleteCall(firstPhone.CallHistory[1]); // Deleting call with index 1 counting from 0

        firstPhone.DisplayHistory();
        Console.WriteLine("Price of calls: " + firstPhone.CalculatePrice(0.37m));

        firstPhone.ClearHistory(); // Clearing the whole history
        firstPhone.DisplayHistory();
        Console.WriteLine("Price of calls: " + firstPhone.CalculatePrice(0.37m));
    }
}