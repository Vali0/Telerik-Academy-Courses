using System;

class Program
{
    static void Main(string[] args)
    {
        int[] input = new int[5];
        string temp;
        byte catcha = 0;
        for (int i = 0; i < 5; i++)
        {
            temp = Console.ReadLine();
            if (temp == "J")
                input[i] = 11;
            else if (temp == "Q")
                input[i] = 12;
            else if (temp == "K")
                input[i] = 13;
            else if (temp == "A")
                input[i] = 1;
            else
                input[i] = int.Parse(temp);
        }
        Array.Sort(input);
        if (input[0] == input[1] && input[0] == input[2] && input[0] == input[3] && input[0] == input[4])
            Console.WriteLine("Impossible");
        else if ((input[0] == input[1] && input[0] == input[2] && input[0] == input[3]) || (input[1] == input[2] && input[1] == input[3] && input[1] == input[4]))
            Console.WriteLine("Four of a Kind");
        else if (((input[0] == input[1] && input[0] == input[2]) && (input[3] == input[4])) || ((input[2] == input[3] && input[2] == input[4]) && (input[0] == input[1])))
            Console.WriteLine("Full House");
        else if ((input[0] + 1 == input[1] || input[0] == 1) && input[1] + 1 == input[2] && input[2] + 1 == input[3] && input[3] + 1 == input[4])
            Console.WriteLine("Straight");
        else if ((input[0] == input[1] && input[0] == input[2]) || (input[1] == input[2] && input[1] == input[3]) || (input[2] == input[3] && input[2] == input[4]))
            Console.WriteLine("Three of a Kind");
        else
        {
            for (int i = 0; i < input.Length - 1; i++)
                for (int j = i + 1; j < input.Length; j++)
                    if (input[i] == input[j])
                    {
                        catcha++;
                    }

            if (catcha == 0)
                Console.WriteLine("Nothing");
            else if (catcha == 2)
                Console.WriteLine("Two Pairs");
            else if (catcha == 1)
                Console.WriteLine("One Pair");
        }
    }
}
