using System;

class Program
{
    static void Main(string[] args)
    {
        int tomatoAmount = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberAmount = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int patatoAmount = int.Parse(Console.ReadLine());
        int patatoArea = int.Parse(Console.ReadLine());
        int carrotAmount = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageAmount = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansAmount = int.Parse(Console.ReadLine());
        float cost = tomatoAmount * 0.5f + cucumberAmount * 0.4f + patatoAmount * 0.25f + carrotAmount * 0.6f + cabbageAmount * 0.3f + beansAmount * 0.4f;
        int area = 250 - (tomatoArea + cucumberArea + patatoArea + carrotArea + cabbageArea);


        Console.WriteLine("Total costs: {0:F2}", cost);

        if (area > 0)
            Console.WriteLine("Beans area: " + area);7
        else if (area == 0)
            Console.WriteLine("No area for beans");
        else if (area < 0)
            Console.WriteLine("Insufficient area");

    }
}