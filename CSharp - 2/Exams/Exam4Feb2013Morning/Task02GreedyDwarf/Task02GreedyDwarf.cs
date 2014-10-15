using System;

class Task02GreedyDwarf
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().Trim();
        input = input.Replace(" ", null);
        string[] valley = input.Split(',');

        string[] myValley = new string[valley.Length];
        
        for (int j = 0; j < valley.Length; j++)
        {
            myValley[j] = valley[j];
        }

        int m = int.Parse(Console.ReadLine());
        int mostCoins = 0;
        int coinsCounter = 0;
        int valleyIndex = 0;
        int patternIndex = 0;

        for (int i = 0; i < m; i++)
        {
            input = Console.ReadLine().Trim();
            input = input.Replace(" ", null);
            string[] pattern = input.Split(',');

            coinsCounter = 0;
            valleyIndex = 0;
            patternIndex = 0;

            while (valleyIndex >= 0 && valleyIndex < valley.Length)
            {
                if (valley[valleyIndex] != "*")
                {
                    coinsCounter += Convert.ToInt32(valley[valleyIndex]);
                    valley[valleyIndex] = "*";
                    
                    if (patternIndex < pattern.Length)
                    {
                        valleyIndex += Convert.ToInt32(pattern[patternIndex]);
                        patternIndex++;
                    }
                    else
                    {
                        patternIndex = 1;
                        valleyIndex += Convert.ToInt32(pattern[patternIndex - 1]);
                    }
                }
                else
                {
                    break;
                }
            }
            
            if (coinsCounter >= mostCoins)
            {
                mostCoins = coinsCounter;
            }
            for (int j = 0; j < valley.Length; j++)
            {
                valley[j] = myValley[j];
            }
        }
        if (mostCoins == 0)
        {
            Console.WriteLine(coinsCounter);
        }
        else
        { 
            Console.WriteLine(mostCoins);
        }
    }
}