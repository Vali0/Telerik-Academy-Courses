using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] player = new int[6];
        string temp;
        int[] firstCards = new int[3];
        int[] secondCards = new int[3];
        int firstSum = 0;
        int secondSum = 0;
        int counterFirst = 0;
        int counterSecond = 0;
        int firstWon = 0;
        int secondWon = 0;

        int firstScore, secondScore;
        firstScore = 0;
        secondScore = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                temp = Console.ReadLine();

                if (temp == "2")
                    player[j] = 10;
                else if (temp == "3")
                    player[j] = 9;
                else if (temp == "4")
                    player[j] = 8;
                else if (temp == "5")
                    player[j] = 7;
                else if (temp == "6")
                    player[j] = 6;
                else if (temp == "7")
                    player[j] = 5;
                else if (temp == "8")
                    player[j] = 4;
                else if (temp == "9")
                    player[j] = 3;
                else if (temp == "10")
                    player[j] = 2;
                else if (temp == "A")
                    player[j] = 1;
                else if (temp == "J")
                    player[j] = 11;
                else if (temp == "Q")
                    player[j] = 12;
                else if (temp == "K")
                    player[j] = 13;
                else if (temp == "Z")
                    player[j] = -201;
                else if (temp == "Y")
                    player[j] = -200;
                else if (temp == "X")
                    player[j] = 14;
            }

            firstCards[0] = player[0];
            firstCards[1] = player[1];
            firstCards[2] = player[2];
            secondCards[0] = player[3];
            secondCards[1] = player[4];
            secondCards[2] = player[5];


            Array.Sort(firstCards);
            Array.Sort(secondCards);

            foreach (var item in firstCards)
            {
                if (item == -201)
                    counterFirst++;
            }

            foreach (var item in secondCards)
            {
                if (item == -201)
                    counterSecond++;
            }

            if (firstCards[2] == 14)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (secondCards[2] == 14)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }
            else if ((firstCards[2] == secondCards[2]) && (secondCards[2] == 14))
            {
                firstScore += 50;
                secondScore += 50;
            }

            if (counterFirst == 0)
            {
                firstSum = player[0] + player[1] + player[2];
            }
            else if (counterFirst != 0)
            {
                for (int k = counterFirst; k < 3; k++)
                    firstSum += player[k];
            }

            if (counterSecond == 0)
            {
                secondSum = player[3] + player[4] + player[5];
            }
            else if (counterSecond != 0)
            {
                for (int k = counterSecond; k < 3; k++)
                    secondSum += player[k];
            }
            if (firstSum > secondSum)
            {
                firstScore += firstSum;
                firstWon++;
            }
            else if (firstSum < secondSum)
            {
                secondScore += secondSum;
                secondWon++;
            }
        }
        if (firstScore > secondScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: " + firstScore);
            Console.WriteLine("Games won: " + firstWon);
        }
        else if (secondScore > firstScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: " + secondScore);
            Console.WriteLine("Games won: " + secondWon);
        }
        else if (firstScore == secondScore)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: " + firstScore);
        }
    }
}