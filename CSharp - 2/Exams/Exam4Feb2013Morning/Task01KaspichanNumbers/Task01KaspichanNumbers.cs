using System;
using System.Text;

class Task01KaspichanNumbers
{
    static void Main(string[] args)
    {
        ulong input = ulong.Parse(Console.ReadLine());
        string[] kaspichan = KaspichanNumbers();

        StringBuilder sb = new StringBuilder();

        if (input == 0)
        {
            Console.WriteLine(kaspichan[0]);
            return;
        }

       string result = null;
       while (input != 0)
       {
           result = kaspichan[input % 256] + result;
           input /= 256;
       }
       Console.WriteLine(result);
    }
    public static string[] KaspichanNumbers()
    {
        string[] numbers = new string[256];

        for (int i = 0; i < 256; i++)
        {
            if (i < 26)
            {
                numbers[i] = ((char)('A' + i)).ToString();
            }
            else if (i < 2 * 26)
            {
                numbers[i] = "a" + numbers[i - 26];
            }
            else if (i < 3 * 26)
            {
                numbers[i] = "b" + numbers[i - 2*26];
            }
            else if (i < 4 * 26)
            {
                numbers[i] = "c" + numbers[i - 3*26];
            }
            else if (i < 5 * 26)
            {
                numbers[i] = "d" + numbers[i - 4*26];
            }
            else if (i < 6 * 26)
            {
                numbers[i] = "e" + numbers[i - 5*26];
            }
            else if (i < 7 * 26)
            {
                numbers[i] = "f" + numbers[i - 6*26];
            }
            else if (i < 8 * 26)
            {
                numbers[i] = "g" + numbers[i - 7*26];
            }
            else if (i < 9 * 26)
            {
                numbers[i] = "h" + numbers[i - 8*26];
            }
            else if (i < 10 * 26)
            {
                numbers[i] = "i" + numbers[i - 9*26];
            }

        }

        return numbers;
    }
}